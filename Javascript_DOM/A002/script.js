"use strict";

var inputs = document.querySelectorAll("input");

(function () {
  for (const value of inputs) {
    value.addEventListener("focusin", focusIn);
    value.addEventListener("focusout", focusOut);
  }
})();

function focusIn(e) {
  e.target.style.backgroundColor = "#ebfbff";
  console.log("In");
}

function focusOut(e) {
  e.target.style.backgroundColor = "white";
  console.log("Out");
}
