"use strict";
var btn = document.getElementById("btnChoix");
var btnRadioList = document.getElementsByName("btnRadChoix");

btn.addEventListener("click", clickChoice);

function clickChoice() {
  for (const value of btnRadioList) {
    if (value.checked) {
      document.getElementById("txtChoix").value = value.value;
    }
  }
}
