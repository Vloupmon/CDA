
/* script de test des personnes */

// Déclaration des options de date pour présentation textuelle
var options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };

date1 = new Date(1962,0,13);
date2 = new Date(1961,12,13);

alert(date1 + " " + date2)
// instanciation de 2 objets
console.log('*** tests sur objets instanciés ***');
var vincent = new Personne('Bost', 'Vincent', new Date(1962,0,13)) ;
var jean = new Personne('Morillon', 'Jean', new Date(1959,9,27)) ;
// manipulation d’un objet
console.log('Age vincent : ' + vincent.age()); // ok : 58
console.log('vincent dateNaissance : ' + vincent.dateNaissance); // erreur
console.log('vincent dateNaissance : ' + vincent.getDateNaissance().
toLocaleDateString('fr-FR', options)) ; 
console.log('vincent nom : ' + vincent.nom) ; // ok Bost
