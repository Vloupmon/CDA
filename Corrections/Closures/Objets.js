function Personne(nomx, prenomx, dateNaissancex) { // constructeur d'initialisation
  this.nom = nomx ; // attribut exposé publiquement
  this.prenom = prenomx ; // attribut exposé publiquement
  var dateNaissance = dateNaissancex; // attribut privé
  
  // méthode calcul de l'âge
  this.age = function(){
    return new Number((new Date().getTime() - dateNaissance.getTime())/ 31536000000).toFixed(2);
  } 
  
  // setter date de naissance avec contrôle
  this.setDateNaissance = function(dateNaissancex) {
		dateNaissance = dateNaissancex;}
	
  // getter date de naissance
  this.getDateNaissance = function()
  {return dateNaissance ;}
  
} ;