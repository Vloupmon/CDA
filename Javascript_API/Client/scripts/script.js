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
    console.log(place);
    placesList.push({
      city: place["place name"],
      latitude: place["latitude"],
      longitude: place["longitude"],
    });
  }
  console.log(placesList);
}

function setPlaces() {}
