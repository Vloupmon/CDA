"use strict";

const placesList = new Array();

$(document).ready(function () {
  $("#zipCode").keyup(function (e) {
    if (
      $(this).val().length == 5 &&
      $(this)
        .val()
        .match(/[0-9]{5}$/g)
    ) {
      zipCodeFetch($(this).val());
    }
  });

  $("#city").change(function (e) {
    console.log(e.target.value);
  });

  $("form").validate({
    rules: {
      name: "required",
      userName: "required",
      birthDay: "required",
      email: {
        required: true,
        email: true,
      },
      street: "required",
      suite: {
        required: false,
      },
      zipCode: "required",
      phone: "required",
    },
    submitHandler: function () {
      setData();
    },
  });
});

function zipCodeFetch(zipCode) {
  var hdrs = new Headers();
  var initialisation = {
    method: "GET",
    headers: hdrs,
    mode: "cors",
    cache: "default",
  };
  var requete = new Request(
    "https://api.zippopotam.us/fr/" + zipCode,
    initialisation
  );
  fetch(requete)
    .then(async function (response) {
      if (response.ok) {
        const json = await response.json();
        setPlacesArray(json.places);
        setPlacesInput();
      } else {
        console.log("Bad answer from the server");
      }
    })
    .catch(function (error) {
      console.log("There's a problem with the fetch request: " + error.message);
    });
}

function setPlacesArray(jsonPlaces) {
  placesList.length = 0;

  for (const place of jsonPlaces) {
    placesList.push({
      city: place["place name"],
      latitude: place["latitude"],
      longitude: place["longitude"],
    });
  }
  console.log(placesList);
  setPlacesInput();
}

function setPlacesInput() {
  $.each(placesList, function (key, value) {
    $("#city").append($("<option>", { value: key }).text(value.city));
  });
}

function setData() {
  /*  var jsonData = JSON.stringify({
    name: $("#name").val(),
    placesList
  });*/
  var jsonData = $("form").serializeJSON();
  var geo = {
    latitude: placesList[$("#city").val()]["latitude"],
    longitude: placesList[$("#city").val()]["longitude"],
  };
  console.log(geo);
  jsonData.address.geo = geo;
  console.log(jsonData);
}
