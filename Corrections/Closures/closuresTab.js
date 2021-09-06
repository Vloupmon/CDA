const tableau = document.createElement("TABLE");
window.onload = function () {

    const stagiaires = [{ nom: "Boisserie", prenom: "Julien" },
    { nom: "Cazal", prenom: "Fabrice" },
    { nom: "Cheney", prenom: "Jérémie" },
    { nom: "Dobelin", prenom: "nicolas" }];
    creerTableau(stagiaires);
    colorierTableau();
    AjouterEvenementTableau();
};

function creerTableau(stagiaires) {

    for (i = 0; i < stagiaires.length; i++) {

        if (i === 0) // création entête et corps
        {
            const entete = tableau.createTHead();
            const row = entete.insertRow();

            for (const key in stagiaires[i]) {
                const cel = row.insertCell(-1);
                cel.innerHTML = key;
            }
            var corps = tableau.createTBody();
        }
        const row = corps.insertRow();
        for (const key in stagiaires[i]) {
            const cel = row.insertCell(-1);
            if (stagiaires[i].hasOwnProperty(key)) {
                cel.innerHTML = stagiaires[i][key];
            }
        }
    }
    document.getElementById("tableauStagiaires").appendChild(tableau);

};
function AjouterEvenementTableau() {
    for (let i = 0; i < tableau.tBodies[0].rows.length; i++) {
        tableau.tBodies[0].rows[i].addEventListener('click', function () {
            alert("La ligne " + i + " a été sélectionnée");
        }, false);
    };
}
function colorierTableau() {
    //   for(let i = 0;i<tableau.tBodies[0].rows.length;i++)
    //   {
    //     tableau.tBodies[0].rows[i].style.backgroundColor = "yellow";
    //   };

    for (let i = 0; i < tableau.tBodies[0].rows.length; i++) {
        window.setTimeout(
            /* Argument 1 : Fonction à lancer après le délai */
            (function (indice) {
                // "indice" prendra la valeur de "i" lors de l'exécution du cycle 
                // Fonction à exécuter à la fin du délai défini dans
                // "setTimeout"
                var a = function () {
                    tableau.tBodies[0].rows[indice].style.backgroundColor = "yellow";
                };
                console.log("closure fonction " + a + " indice " + indice)
                return a;
            })(i), // on passe en argument le compteur de la boucle
            1000 * (i + 1) // on calcul le délai
        );
    }
}

