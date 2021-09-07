"use strict";

$(document).ready(function () {
  $(":input").keyup(function (e) {
    if (
      $(this).val().length < 5 ||
      ($(this).attr("id") === "confirmation" &&
        $(this).val() != $("#password").val())
    ) {
      $(this).css("outline-color", "red");
    } else {
      $(this).css("outline-color", "GreenYellow");
    }
  });
});
