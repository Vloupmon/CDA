"use strict";

const placesList = new Array();
var imgData;

$(document).ready(function () {
  $("#zipCode").keyup(function (e) {
    if (
      $(this).val().length == 5 &&
      $(this)
        .val()
        .match(/[0-9]{5}$/g)
    ) {
      getZipCodeData($(this).val());
    }
  });

  $("#fileInput").on("change", function () {});

  $("#imgForm").change(function () {
    var fileReader = new FileReader();
    fileReader.onload = function () {
      imgData = fileReader.result;
    };
    fileReader.readAsDataURL($("#btnFiles").prop("files")[0]);
  });

  $("#userForm").validate({
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
      postUser();
    },
  });
});

async function userSubmitHandler() {
  const userId = await postUser();
  console.log("userId: " + userId);
  //postImg(userId);
}

function getZipCodeData(zipCode) {
  var headers = new Headers();
  var init = {
    method: "GET",
    headers: headers,
    mode: "cors",
    cache: "default",
  };
  var request = new Request("https://api.zippopotam.us/fr/" + zipCode, init);
  fetch(request)
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

async function postUser() {
  var jsonData = formDataToJson();
  var init = {
    method: "POST",
    body: jsonData,
    headers: {
      "Content-Type": "application/json",
    },
  };
  var request = new Request("https://localhost:44331/api/users", init);

  fetch(request)
    .then(async function (response) {
      if (response.ok) {
        const json = await response.json();
        if (json.userId != null) {
          console.log(response);
          postImg(json.userId);
        }
      } else {
        console.log("Bad answer from the server");
        return false;
      }
    })
    .catch(function (error) {
      console.log("There's a problem with the fetch request: " + error.message);
      return false;
    });
}

function postImg(userId) {
  const headers = new Headers();
  const init = {
    method: "POST",
    body: imgData,
    headers: headers,
  };
  const request = new Request(
    "https://localhost:44331/api/UploadImages/" + userId,
    init
  );

  fetch(request)
    .then(async function (response) {
      if (response.ok) {
        console.log(response.body);
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
  setPlacesInput();
}

function setPlacesInput() {
  $.each(placesList, function (key, value) {
    $("#city").append($("<option>", { value: key }).text(value.city));
  });
}

function formDataToJson() {
  var jsonData = JSON.stringify(
    {
      name: $("#name").val(),
      userName: $("#userName").val(),
      email: $("#email").val(),
      address: {
        street: $("#street").val(),
        suite: $("#suite").val(),
        city: $("#city option:selected").text(),
        zipcode: $("#zipCode").val(),
        geo: {
          latitude: placesList[$("#city").val()]["latitude"],
          longitude: placesList[$("#city").val()]["longitude"],
        },
      },
      phone: $("#phone").val(),
      birthDay: $("#birthDay").val(),
    },
    null,
    "\t"
  );
  return jsonData;
}
