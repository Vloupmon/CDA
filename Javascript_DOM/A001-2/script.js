"use strict";
var btn = document.getElementById("btnChoix");
var btnRadio = document.getElementsByName("btnRadChoice");

for (const value of btnRadio) {
}

btn.addEventListener("click", clickChoice);

function clickChoice() {
  console.log(document.getElementById("txtChoix").value);
}
