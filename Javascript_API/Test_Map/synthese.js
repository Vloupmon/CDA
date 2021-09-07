/*Code Postal Geo API Gouv*/

const txtCodepostal = document.getElementById("txtCodepostal")
const lstVille = document.getElementById("lstVille")
let listeCommunes = []

txtCodepostal.addEventListener("input", onchangeCodePostal)

async function fetchAPIrequest(request) {
    const response = await fetch(request)
    const json = await response.json()
    return json
}

async function recuperationCommunes(codePostal) {
    listeCommunes = await fetchAPIrequest("https://geo.api.gouv.fr/communes?codePostal=" + codePostal + "&fields=contour")
    //console.log(listeCommunes)
    lstVille.innerHTML = ""
    for (const commune of listeCommunes) {
        lstVille.innerHTML += "<option value=\"" + commune.nom + "\">" + commune.nom + "</option>"
    }
    onchangeCommune()
}

function onchangeCodePostal() {
    if (txtCodepostal.value.length == 5) {
        recuperationCommunes(txtCodepostal.value)
    }
}

/*Selecteur commune*/

lstVille.addEventListener('change', onchangeCommune)

function onchangeCommune() {
    const communeSelectionnnee = getCommuneSelec()
    //console.log(communeSelectionnnee)
    chargementPolygon(inversePolygonLatLon(communeSelectionnnee.contour.coordinates[0]))
}

function getCommuneSelec() {
    return listeCommunes[lstVille.selectedIndex]
}
function inversePolygonLatLon(wrongPolygon) {
    let goodPolygon = []
    for (const latlong of wrongPolygon) {
        goodPolygon.push([latlong[1], latlong[0]])
    }
    return goodPolygon
}

/*Leaflet*/

const boudingFrance = [
    [51.268318, -5.4534286],
    [41.2632185, 9.8678344]
]
const map = L.map('map').fitBounds(boudingFrance)
let polygon
const osmfr = L.tileLayer('https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>'
})

function chargerCarte() {
    osmfr.addTo(map)
}
function chargementPolygon(polygonCoords) {
    if (polygon != null) {
        map.removeLayer(polygon)
    }
    polygon = L.polygon(polygonCoords, { color: 'blue', fillOpacity: 0.2 }).addTo(map)
    map.fitBounds(polygon.getBounds());
}
chargerCarte()

/*Formulaire*/

const btnClear = document.getElementById('btnClear')
const btnValid = document.getElementById('btnValid')
const btnFiles = document.getElementById('btnFiles')
const divPreview = document.getElementById('previewFiles')

btnClear.addEventListener("click", onclickClear)
btnValid.addEventListener("click", onclickValid)
btnFiles.addEventListener("change", onselectionFiles)

function onclickClear() {
    lstVille.innerHTML = ""
    divPreview.innerHTML = ""
    map.removeLayer(polygon).flyToBounds(boudingFrance)
}
function onselectionFiles() {
    divPreview.innerHTML = ""
    for (const fichier of btnFiles.files) {
        //console.log(fichier)
        if (fichier.type.includes("image")) {
            let reader = new FileReader();
            reader.addEventListener("load", function () {
                let image = new Image()
                image.height = 100
                image.title = fichier.name
                image.src = this.result
                divPreview.appendChild(image)
            }, false)
            reader.readAsDataURL(fichier)
        }
    }
}

const txtNom = document.getElementById('txtNom')
const txtPrenom = document.getElementById('txtPrenom')
const dtpNaissance = document.getElementById('dtpNaissance')
const txtEmail = document.getElementById('txtEmail')
const txtTel = document.getElementById('txtTel')
const txtAddress1 = document.getElementById('txtAddress1')
const txtAddress2 = document.getElementById('txtAddress2')

async function onclickValid(e) {
    //https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch
    //validation, champs obligatoires, etc.

    // e.preventDefault()
    // e.stopPropagation() //ne change rien au problème du reload

    //console.log(getJSONuser())
    let valid = true
    const userId = await createUserFetch()
    console.log("userID : " + userId)

    if (typeof (userId) != "undefined") {
        if (btnFiles.files.length != 0) {
            const formData = new FormData()

            for (const fichier of btnFiles.files) {
                if (fichier.type.includes("image")) {
                    console.log(fichier)
                    formData.append('files', fichier)
                }
            }
            valid = await sendImage(userId, formData)
            //il ne traite qu'une image à la fois, aucun intéret d'envoyer un groupe
        }
    } else {
        valid = false
    }

    if (valid) {
        alert("Envoi réussi")
        //le reload se fait automatiquement (trop vite sous FF)
    }
}
function getJSONuser() {
    const json = {
        "name": txtNom.value,
        "userName": txtPrenom.value + " " + txtNom.value,
        "email": txtEmail.value,
        "address": {
            "street": txtAddress1.value,
            "suite": txtAddress2.value,
            "city": lstVille.value,
            "zipcode": txtCodepostal.value,
            "geo": {
                "latitude": map.getCenter().lat.toString(),
                "longitude": map.getCenter().lng.toString()
            }
        },
        "phone": txtTel.value,
        "birthDay": dtpNaissance.value
    }
    return JSON.stringify(json)
}
async function sendImage(userId, imagesFormData) {
    try {
        const response = await fetch('https://localhost:44331/api/upload/' + userId, {
            method: 'POST',
            body: imagesFormData

        });
        const json = await response.json()
        const result = JSON.stringify(json)
        console.log(result)
        return (!result.includes("error"))
    } catch (error) {
        console.error('Erreur avant l\'envoi :', error);
        return false
    }
}
async function createUserFetch() {
    let userId
    try {
        const response = await fetch('https://localhost:44331/api/users/', {
            method: 'POST',
            body: getJSONuser(),
            headers: {
                'Content-Type': 'application/json'
            }
        });
        const json = await response.json();
        if (json.userId != null) {
            userId = json.userId
        }
        return userId
    } catch (error) {
        console.error('Error:', error);
        return
    }
}
//TODO 
//validation
//prévention des fichiers qui ne sont pas des images


/* Fonctions de test */
function remplirLesChamps() {
    btnFiles.value = null
    txtNom.value = "Loiseau"
    txtPrenom.value = 'Robert'
    dtpNaissance.value = "1970-05-19"
    txtEmail.value = "bobLoiseau@email.com"
    txtTel.value = "0948561245"
    txtAddress1.value = "1 rue du merle"
    txtAddress2.value = "Sur le toit"
    txtCodepostal.value = "75001"
    recuperationCommunes(txtCodepostal.value)
}
window.addEventListener("load", remplirLesChamps)
async function getLastUserID() {

}
async function nettoyerBDD() {

}


/* exemple XMLHttpRequest */
function sendData(data, userId) {
    let XHR = new XMLHttpRequest();
    let FD = new FormData();

    // Push our data into our FormData object
    for (name in data) {
        FD.append(name, data[name]);
    }
    // Define what happens on successful data submission
    XHR.addEventListener('load', function (event) {
        alert(XHR.responseText);
    });
    // Define what happens in case of error
    XHR.addEventListener('error', function (event) {
        alert('Something went wrong.');
    });
    // Set up our request
    XHR.open('POST', 'https://localhost:44331/api/upload/' + userId);
    // Send our FormData object; HTTP headers are set automatically
    XHR.send(FD);
}