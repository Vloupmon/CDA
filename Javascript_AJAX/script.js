"use strict";

function getXMLHTTPRequest() {
  var xMLHTTpR;
  xMLHTTpR = new XMLHttpRequest();

  return xMLHTTpR;
}

var ptr = getXMLHTTPRequest();

ptr.open("GET", "https://jsonplaceholder.typicode.com/todos/", true);
ptr.setRequestHeader("Content-type", "application/json");

ptr.onreadystatechange = function () {
  if (ptr.readyState == 4 && ptr.status == 200) {
    console.log(ptr.responseText);
  }
};

ptr.onabort = function () {
  alert("Request aborted");
};

ptr.onerror = function () {
  alert("Request failed");
};

ptr.send(null);
