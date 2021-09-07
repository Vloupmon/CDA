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

  $("#submitbtn").click(function (e) {
    if ($("#password").val() === "testt") {
      $("#form-example").submit(function (e) {
        return false;
      });
    }
  });
});
