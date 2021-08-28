// init variables
var decompte; // ref objet timer
var tpsEcoule = 0; // nbre secondes
// refs objets DOM
var chronoP = document.getElementById("chrono");
var btnStart = document.getElementById("btnStart");
var btnPause = document.getElementById("btnPause");
var btnStop = document.getElementById("btnStop");

(function () {
  btnStart.setAttribute("paramtps", 0);
  btnStart.addEventListener("click", startChrono);
  btnPause.setAttribute("paramtps", 0);
  btnPause.addEventListener("click", pauseChrono);
  btnStop.addEventListener("click", stopChrono);
})();

function pad(num) {
  if (num < 10) {
    return "0" + num;
  } else return num;
}

function startChrono(e) {
  btnStart.removeEventListener("click", startChrono);
  btnPause.removeEventListener("click", startChrono);
  btnPause.addEventListener("click", pauseChrono);
  btnStart.className = "invi";
  btnPause.className = "visi";
  btnStop.className = "visi";
  var startTime = new Date();
  decompte = setInterval(function () {
    var seconds = Math.round(
      (new Date().getTime() - startTime.getTime()) / 1000 +
        parseInt(e.target.getAttribute("paramtps"))
    );
    var hours = parseInt(seconds / 3600);
    seconds = seconds % 3600;
    var minutes = parseInt(seconds / 60);
    seconds = seconds % 60;

    chronoP.innerHTML = pad(hours) + ":" + pad(minutes) + ":" + pad(seconds);

    tpsEcoule += 1;
  }, 1000);
}

function pauseChrono(e) {
  clearInterval(decompte);
  btnPause.removeEventListener("click", pauseChrono);
  btnPause.addEventListener("click", startChrono);
  e.target.setAttribute("paramtps", tpsEcoule);
}

function stopChrono(e) {
  clearInterval(decompte);
  btnPause.removeEventListener("click", startChrono);
  btnPause.removeEventListener("click", pauseChrono);
  btnStop.removeEventListener("click", stopChrono);
  btnStart.addEventListener("click", startChrono);
  chronoP.innerHTML =
    '<span id="h">00</span>:<span id="m">00</span>:<span id="s">00</span>';
  btnStart.className = "visi";
  btnPause.className = "invi";
  btnStop.className = "invi";
}
