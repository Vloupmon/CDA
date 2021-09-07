// demoDOM.js : utilisation du DOM en jQuery
//  
//  ajout en fin de zone de test
function onBtnClickFin()
{    
    $("#divtest").append  ( $("#nouveau").val () );  
}
 
// cette fonction crée ou initialise tous les composants
// du document et leur associe des méthodes événementielles
function initComponents()
{   
    $("#btnAjoutFin").click (onBtnClickFin) ;    
}
// appelle la fonction d’initialisation après chargement du document
$(document).ready (initComponents) ;



