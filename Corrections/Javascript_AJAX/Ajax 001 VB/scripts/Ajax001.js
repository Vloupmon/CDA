"use strict";
// Constantes Globales
const listeUtilisateurs = new Array();
const listeArticles = new Array();
/*
Instanciation de l'objet XMLHTTPRequest
en fonction de la version du navigateur
*/
function getXMLHttpRequest() {
    var xMLHttpR;

    if (window.XMLHttpRequest) {
        xMLHttpR = new XMLHttpRequest();
    }
    else if (window.ActiveXObject) {
        try {
            xMLHttpR = new ActiveXObject("Msxml12.XMLHTTP");
        } catch (e) {
            xMLHttpR = new ActiveXObject("Microsoft.XMLHTTP");
        }
    }
    return xMLHttpR;
}
/*
Traitement du flux Json
*/
function deserialJson(jSonParse) {
    
    listeUtilisateurs.length=0;
  
    for (var i = 0; i < jSonParse.length; i++) {
        listeUtilisateurs.push(
            {nom: jSonParse[i].name,
             siteWeb: jSonParse[i].website,
             email:jSonParse[i].email,
             id: jSonParse[i].id,
             getPosts:getLienPosts(jSonParse[i].id)
        });
    }
    console.log(listeUtilisateurs);
    chargerTableauUtilisateurs();
}
function getLienPosts(id){
var bouton = '<button type="button" class="btn btn-primary btn-sm" onclick=chargerPosts(' 
+ id 
+')>Articles</button>';
return bouton;
}
function chargerPosts(id)
{
   
    document.getElementById('titreModal').innerHTML=
    listeUtilisateurs.find(util=>util.id==id).nom;
   listeArticles.length=0;
    var entetes = new Headers();
var initialisation = { method: 'GET',
               headers: entetes,
               mode: 'cors',
               cache: 'default' };
var requete = new Request('https://jsonplaceholder.typicode.com/posts?userId='+id,initialisation);               
fetch(requete).then(function(response) {
    if(response.ok) {
        return response.json().then(function(json) {
            for (var i = 0; i < json.length; i++) {
                listeArticles.push(
                    {titre: json[i].title,
                     corps: json[i].body
                });
          }
          chargerArticles();
          var myModal = new bootstrap.Modal(document.getElementById('affichageArticles'))
          myModal.show()
        });
         
        
     } else {
      console.log('Mauvaise réponse du réseau');
    }
  })
  .catch(function(error) {
    console.log('Il y a eu un problème avec l\'opération fetch: ' + error.message);
  });

}
function chargerArticles()
{
   $('#articles').DataTable( {
       destroy:true,
        data: listeArticles,
        columns: [
            { title: "Titre",data: "titre"},
            { title: "Détails",data:"corps" }
        ],
        "autoWidth": false
    });
}
function chargerTableauUtilisateurs()
{
    $('#utilisateurs').DataTable( {
        "language": {
            "lengthMenu": "Afficher _MENU_ éléments par page",
            "zeroRecords": "Aucun résultat trouvé",
            "search": "Recherche :",
            "info": "Affichage page _PAGE_ de _PAGES_",
            "infoEmpty": "Aucun enregistrement",
            "infoFiltered": "(filtrés parmi _MAX_ enregistrements)",
            "paginate": {
                    "first":      "Premier",
                    "last":       "Dernier",
                    "next":       "Suivant",
                    "previous":   "Précédent"
                }
        },
        data: listeUtilisateurs,
        columns: [
            { title: "Nom",data: "nom"},
            { title: "Site Web",data:"siteWeb" },
            { title: "Email" , data:"email"},
            { title: "Articles",data:"getPosts" }
        ]
    } );
}
function chargerXMLHttpR()
{
    var XHTR = getXMLHttpRequest();
    var methodHTTP = 'GET';
    var url = 'https://jsonplaceholder.typicode.com/users';
    var send = null;
    
    XHTR.open(methodHTTP, url, true);

    XHTR.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");

    XHTR.onreadystatechange = function () {
        if (XHTR.readyState === 4 && XHTR.status === 200) {
             deserialJson(JSON.parse(XHTR.responseText)); 
        }
    };
    XHTR.send(send);
}
function chargerAjaxJQ()
{
    $.ajax({
        url: 'https://jsonplaceholder.typicode.com/users',
        type: 'GET',
        data: null,
        dataType: 'json',
        success: function (resultat, statut) {
            console.log("Succès", resultat, statut);
        },
        error: function (resultat, statut, erreur) {
            console.log("Erreur", erreur, statut);
        },

        complete: function (resultat, statut) {
            deserialJson(JSON.parse(resultat.responseText));
        }
    });
}
function chargerFetch()
{
var entetes = new Headers();
var initialisation = { method: 'GET',
               headers: entetes,
               mode: 'cors',
               cache: 'default' };
var requete = new Request('https://jsonplaceholder.typicode.com/users',initialisation);               
fetch(requete).then(function(response) {
    if(response.ok) {
        return response.json().then(function(json) {
         deserialJson(json);
          });
         
        
     } else {
      console.log('Mauvaise réponse du réseau');
    }
  })
  .catch(function(error) {
    console.log('Il y a eu un problème avec l\'opération fetch: ' + error.message);
  });

}


$(document).ready(function() {
   // chargerFetch();
  // chargerAjaxJQ();
  chargerXMLHttpR();
} );