"use strict";
var btn = document.getElementById("btnChoix");
var btnRadioList = document.getElementsByName("btnRadChoix");

btn.addEventListener("click", clickChoice);

function clickChoice() {
  for (const val of btnRadioList) {
    if (val.checked) {
      document.getElementById("txtChoix").value = val.value;
    }
  }
}
