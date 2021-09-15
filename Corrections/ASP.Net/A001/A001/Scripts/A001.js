// Variables Globales
var listePays = new Array();
// Constante
const cExpRegMail = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]{2,}\.[a-z]{2,4}$/;

//
// Efface les messages span 
//
function EffacerMessagesErreurs(nomTag) {

    var elements = document.getElementsByTagName(nomTag);
    for (i = 0; i < elements.length; i++) {
        if (elements[i].id.substring(0, 2) === 'M_')
            elements[i].style.visibility = 'hidden';
    }
}
//
// Affiche le message dont l'Id est passé en argument
//
function AfficherMessageErreur(idMessage) {
    var element = document.getElementById(idMessage);
    element.style.visibility = 'visible';
}

//
// Vérifie présence d'une Valeur
//
function hasValeur(chaine) {
    return chaine.length > 0;
}
//
// Vérifie qu'il y ait un élément sélectionné
//
function isInteretsValide() {
    var interets = document.getElementsByName('chkInterets');

    for (var i = 0; i < interets.length; i++) {
        if (interets[i].checked) return true;
    }
    return false;
}
//
// Récupère la Valeur du pays
//
function findPays(idPays2) {
    for (var i in listePays) {
        if (listePays[i].id == idPays2) return listePays[i];
    }
    return null;
}
function envoyer() {
    if (isFormulaireValide())
    {
        var formulaire = document.getElementById('frmCoordonnees');
        var methodes = document.getElementsByName("rdMethode");
        for (var i = 0; i < methodes.length; i++) {
            if (methodes[i].checked) {
                if (methodes[i].value == "GET")
                    formulaire.method = methodes[i].value;
                else formulaire.method = "POST"
            }
        }
        var actions = document.getElementsByName("rdAction");
        for (var i = 0; i < actions.length; i++) {
            if (actions[i].checked) {
                formulaire.action = actions[i].value;
               
            }
        }
        formulaire.submit();
    };
}
function isFormulaireValide() {
    var idPays = document.forms['frmCoordonnees'].elements['selPays'][document.forms['frmCoordonnees'].elements['selPays'].selectedIndex].value;
    var paysCourant = (idPays) ? findPays(idPays) : null;
    var bNom = hasValeur(document.getElementById('txtNom').value);
    var bPrenom = hasValeur(document.getElementById('txtPrenom').value);
    var bAdresse = hasValeur(document.getElementById('txtAdresse_P1').value);
    var bCodePostal = hasValeur(document.getElementById('txtCodePostal').value);
    var bVille = hasValeur(document.getElementById('txtVille').value);
    var bMail = hasValeur(document.getElementById('txtMail').value);
    if (bCodePostal) {
        var expRegCPostal = new RegExp(paysCourant.formatCodePostal);
        bCodePostal = expRegCPostal.test(document.getElementById('txtCodePostal').value);
    }
    if (bMail) {
        var expRegMail = cExpRegMail;
        bMail = expRegMail.test(document.getElementById('txtMail').value);
    }
    // Remettre tous les span visibles
    EffacerMessagesErreurs('span');
    // Afficher les erreurs
    if (!bNom) AfficherMessageErreur('M_Nom');
    if (!bPrenom) AfficherMessageErreur('M_Prenom');
    if (!bAdresse) AfficherMessageErreur('M_Adresse');
    if (!bCodePostal || !bVille) {
        var message = document.getElementById('M_CpVille');
        if (!bCodePostal && !bVille)
            message.innerHTML = ' * le code postal et la ville sont erronés';
        else if (!bCodePostal) message.innerHTML = ' * le code postal est erroné';
        else if (!bVille) message.innerHTML = " * la ville n''est pas renseignée";
        AfficherMessageErreur('M_CpVille');
    }
    if (!bMail) AfficherMessageErreur('M_Mail');
    var bInterets = isInteretsValide();
    if (!bInterets) AfficherMessageErreur('M_Interets');
    return (bNom && bPrenom && bAdresse && bCodePostal && bVille && bMail && bInterets);
}

// Change les styles
function ModBlur(e) {
    var elt = e.currentTarget;
    elt.style.backgroundColor = '#72C597';
    elt.style.color = 'white';
}
function ModFocus(e) {
    var elt = e.currentTarget;
    elt.style.backgroundColor = 'white';
    elt.style.color = '#72C597';

}
/*
Fonction anonyme a exécution automatique lors du chargement du script
Execution de la méthode associant les gestionnaires d'événements (prise et perte focus)
Execution de la méthode de chargement des objets Pays
*/
(function () {
    // Chargement des paramètres liés aux pays
    (function () {
        var pays = { id: 'FR', libelle: 'France', formatCodePostal: '^[0-9]{5}$' };
        listePays.push(pays);
        pays = { id: 'UK', libelle: 'Royaume Uni', formatCodePostal: '^((GIR &0AA)|((([A-PR-UWYZ][A-HK-Y]?[0-9][0-9]?)|(([A-PR-UWYZ][0-9][A-HJKSTUW])|([A-PR-UWYZ][A-HK-Y][0-9][ABEHMNPRV-Y]))) &[0-9][ABD-HJLNP-UW-Z]{2}))$' };
        listePays.push(pays);
        pays = { id: 'DE', libelle: 'Allemagne', formatCodePostal: '^[0-9]{5}$' };
        listePays.push(pays);
    }
    )();

    var comboPays = document.getElementById('selPays');
    listePays.forEach(function (paysCourant) {
        var option = document.createElement('Option');
        option.value = paysCourant.id;
        option.text = paysCourant.libelle;
        comboPays.options.add(option);
    });

    // Mise en place des liaisons événements
    (function () {
        var elements = document.getElementsByClassName('inputText')
        for (var i = 0; i < elements.length; i++) {
            elements[i].addEventListener('blur', ModBlur, false);
            elements[i].addEventListener('focus', ModFocus, false);
        }
    }
    )();
})();

