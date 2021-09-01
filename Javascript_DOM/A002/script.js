"use strict";

var inputs = document.querySelectorAll("input");
var countrySelection = document.getElementById("selPays");
var countries = new Map();

// Set country list
countries.set("fr", {
  label: "France",
  phoneRegex: /^(?:(?:\+|00)33|0)s*[1-9](?:[s.-]*d{2}){4}$/gim,
  zipCodeRegex: RegExp("[0-9]{5}", "g"),
});
countries.set("us", {
  label: "USA",
  phoneRegex: /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/g,
  zipCodeRegex: /^\d{5}(-\d{4})?$/g,
});

(function () {
  for (var [key, value] of countries) {
    var opt = document.createElement("option");
    opt.value = key;
    opt.innerText = value.label;
    countrySelection.appendChild(opt);
  }
  for (const value of inputs) {
    value.addEventListener("focusin", focusIn);
    value.addEventListener("focusout", focusOut);
  }
})();

function focusIn(e) {
  e.target.style.backgroundColor = "#ebfbff";
}

function focusOut(e) {
  e.target.style.backgroundColor = "white";
  if (validation(e.target.getAttribute("id"), e.target.value)) {
    inputValid(e);
  } else if (e.target.value) {
    inputInvalid(e);
  }
}

function validation(id, input) {
  var selectedCountry = countries.get(countrySelection.value).value;
  console.log(selectedCounty);
  if (id === "txtCodePostal" && input.match(selectedCountry.zipCodeRegex)) {
    return true;
  }
  if (
    id === "txtMail" &&
    input.match(
      /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/g
    )
  ) {
    return true;
  }
  if (
    id === "txtTelephone" &&
    input.match(/^(?:(?:\+|00)33|0)\s*[1-9](?:[\s.-]*\d{2}){4}$/gim)
  ) {
    return true;
  }
  if (input.match(/[^a-zA-Z]/g)) {
    return true;
  }
  return false;
}

function inputValid(e) {
  e.target.style.backgroundColor = "#0df2c9";
}

function inputInvalid(e) {
  e.target.style.backgroundColor = "rgb(239, 83, 80)";
}
