// Exercice 6 : utilisation du DOM en jQuery
//  

// ajout après l'élément cible
function onBtnClickAfter()
{    
    $("#pcible").after  ( $("#nouveau").val () );  
}
// ajout avant l'élément cible
function onBtnClickBefore()
{    
    $("#pcible").before($("#nouveau").val () );  
}
// ajout en début de zone de test
function onBtnClickDebut()
{    
    $("#divtest").prepend  ( $("#nouveau").val () );  
}
//  ajout en fin de zone de test
function onBtnClickFin()
{    
    $("#divtest").append  ( $("#nouveau").val () );  
}
// supprimer l'élément cible
function onBtnClickSupprimer()
{    
    $("#pcible").remove();  
}
// vider l'élément cible
function onBtnClickVider()
{    
    $("#pcible").remove();  
}


 
 
// cette fonction crée ou initialise tous les composants
// du document et leur associe des méthodes événementielles
function initComponents()
{   
    $("#btnAjoutFin").click (onBtnClickFin) ;
    $("#btnAjoutDebut").click (onBtnClickDebut) ;
    $("#btnAvantCible").click (onBtnClickBefore) ;
    $("#btnApresCible").click (onBtnClickAfter) ;
    $("#btnSupCible").click (onBtnClickSupprimer) ;
    $("#btnViderCible").click (onBtnClickVider) ;
}
// appelle la fonction d’initialisation après chargement du document
$(document).ready (initComponents) ;



