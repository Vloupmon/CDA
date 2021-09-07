"use strict";

let Pierre = new Employe();
Pierre.prenom = "Pierre";
let Paul = new Employe();
Paul.prenom = "Paul";

console.log(Pierre, Paul);

Pierre.chef = Paul;

console.log(Pierre, Paul);
