"use strict";

class Employe {
  #salaire;

  constructor() {
    this.nom = null;
    this.prenom = null;
    this.branche = null;
  }

  getSalaire() {
    return this.#salaire;
  }

  salaireAnnuel() {
    return this.#salaire * 12;
  }

  setSalaire(salaire) {
    if (salaire > this.#salaire) {
      this.#salaire = salaire;
    } else {
      throw new Exception("Salaire inférieur au précédent");
    }
  }
}
