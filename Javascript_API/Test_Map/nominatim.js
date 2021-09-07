/* Free-form Query */

let query = ""
const btnValidGeoQuery = document.getElementById('btnValidGeoQuery')
const btnClearGeoQuery = document.getElementById('btnClearGeoQuery')
const txtGeoQuery = document.getElementById('txtGeoQuery')

btnValidGeoQuery.addEventListener("click", onclickGeoQuery)
btnClearGeoQuery.addEventListener("click", onclickClearGeoQuery)
txtGeoQuery.addEventListener("keypress", onkeypressGeoQuery)

function onclickGeoQuery() {
    query = txtGeoQuery.value
    if (query != "") {
        launchQueryRequest()
    }
}
function onclickClearGeoQuery() {
    txtGeoQuery.value = ""
    clearListeResults()
}
async function launchQueryRequest() {
    resultsQuery = await nominatimRequest('https://nominatim.openstreetmap.org/search?q=' + encodeURIComponent(query) + '&format=json&addressdetails=1')
    traitementResultats()
}
function onkeypressGeoQuery(e) {
    if (e.keyCode == 13) {
        onclickGeoQuery()
    }
}

/* Structured Request */

let street, zipcode, city, country
const btnValidGeocod = document.getElementById('btnValidGeocoding')
const btnClearGeocoding = document.getElementById('btnClearGeocoding')
const txtStreet = document.getElementById('txtStreet')
const txtZipcode = document.getElementById('txtZipcode')
const txtCity = document.getElementById('txtCity')
const txtCountry = document.getElementById('txtCountry')

btnValidGeocod.addEventListener("click", onclickGeocoding)
btnClearGeocoding.addEventListener("click", onclickClearGeocoding)
txtStreet.addEventListener("keypress", onkeypressGeocoding)
txtZipcode.addEventListener("keypress", onkeypressGeocoding)
txtCity.addEventListener("keypress", onkeypressGeocoding)
txtCountry.addEventListener("keypress", onkeypressGeocoding)

function recupererChampsGeocoding() {
    street = txtStreet.value
    zipcode = txtZipcode.value
    city = txtCity.value
    country = txtCountry.value
}
function onclickGeocoding() {
    recupererChampsGeocoding()
    rechercheNominatim()
}
function onclickClearGeocoding() {
    txtStreet.value = ""
    txtZipcode.value = ""
    txtCity.value = ""
    txtCountry.value = ""
    clearListeResults()
}
function onkeypressGeocoding(e) {
    if (e.keyCode == 13) {
        onclickGeocoding()
    }
}
function concatenationChamps() {
    let texte = "https://nominatim.openstreetmap.org/search?"
    if (street != "") {
        texte += "&street=\"" + encodeURIComponent(street) + "\""
    }
    if (zipcode != "") {
        texte += "&postalcode=\"" + encodeURIComponent(zipcode) + "\""
    }
    if (city != "") {
        texte += "&city=\"" + encodeURIComponent(city) + "\""
    }
    if (country != "") {
        texte += "&country=\"" + encodeURIComponent(country) + "\""
    }
    return texte + '&format=json&addressdetails=1'
}
async function rechercheNominatim() {
    const recherche = concatenationChamps()
    resultsQuery = await nominatimRequest(recherche)
    traitementResultats()
}

/* Partie Commune (traitement + affichage) */

let resultsQuery
const listeResultsGeocoding = document.getElementById('listeResultsGeocoding')
const divResults = document.getElementById('divResults')
const btnZoomOutResults = document.getElementById('btnZoomOutResults')

btnZoomOutResults.addEventListener("click", onclickZoomOutResults)

function clearListeResults() {
    listeResultsGeocoding.innerHTML = ""
    divResults.hidden = true
    btnZoomOutResults.hidden = true
    markers = []
    changerLayerCarte(layerMapsArray[selectedLayer])
}
async function nominatimRequest(requete) {
    const response = await fetch(requete);
    const json = await response.json();
    return json;
}
function traitementResultats() {
    clearListeResults()
    if (resultsQuery.length == 0) {
        listeResultsGeocoding.innerHTML = "<b style=\"color: red;\">Pas de résultats</b>"
    }
    else {
        for (let i = 0; i < resultsQuery.length; i++) {
            listeResultsGeocoding.innerHTML += "<li data-geoQueryID=\"" + i + "\">" + resultsQuery[i].display_name + "</li>";
        }
        for (const ligne of listeResultsGeocoding.children) {
            ligne.addEventListener("click", onclickResultList)
        }
        stylizeSelectedList(listeResultsGeocoding.children[0])
        goToBoundingbox(resultsQuery[0])
        traitementAffichageMarkerResults(resultsQuery[0])
        btnZoomOutResults.hidden = false
    }
    divResults.hidden = false
}
function traitementAffichageMarkerResults(resultQuerySelect) {
    for (const element of resultsQuery) {
        if (element != resultQuerySelect) {
            afficherMarker(element.lat, element.lon, couleur.bleu, element.display_name)
        }
    }
    afficherMarker(resultQuerySelect.lat, resultQuerySelect.lon, couleur.orange, resultQuerySelect.display_name)
}
function onclickResultList(e) {
    const ligneClic = e.srcElement
    stylizeSelectedList(ligneClic)
    goToBoundingbox(resultsQuery[ligneClic.dataset.geoqueryid])
    traitementAffichageMarkerResults(resultsQuery[ligneClic.dataset.geoqueryid])
}
function goToBoundingbox(resultQuery) {
    map_osm.flyToBounds([
        [resultQuery.boundingbox[1], resultQuery.boundingbox[2]],
        [resultQuery.boundingbox[0], resultQuery.boundingbox[3]]
    ])
}
function stylizeSelectedList(ligneClic) {
    for (const ligne of listeResultsGeocoding.children) {
        ligne.setAttribute("style", "background-color: ")
    }
    ligneClic.setAttribute("style", "background-color: orange")
}
function onclickZoomOutResults() {
    const ref = resultsQuery[0]
    let minLat = parseFloat(ref.boundingbox[0])
    let maxLat = parseFloat(ref.boundingbox[1])
    let minLon = parseFloat(ref.boundingbox[2])
    let maxLon = parseFloat(ref.boundingbox[3])
    for (const element of resultsQuery) {
        const elMinLat = parseFloat(element.boundingbox[0])
        const elMaxLat = parseFloat(element.boundingbox[1])
        const elMinlon = parseFloat(element.boundingbox[2])
        const elMaxLon = parseFloat(element.boundingbox[3])
        if (elMinLat < minLat) {
            minLat = elMinLat
        }
        if (elMaxLat > maxLat) {
            maxLat = elMaxLat
        }
        if (elMinlon < minLon) {
            minLon = elMinlon
        }
        if (elMaxLon > maxLon) {
            maxLon = elMaxLon
        }
    }
    map_osm.flyToBounds([
        [maxLat, minLon],
        [minLat, maxLon]
    ])
}

/* Reverse nominatim */

const btnInfoPoint = document.getElementById('btnInfoPoint')
btnInfoPoint.addEventListener("click", onclickInformations)

async function onclickInformations() {
    await reverseGeocoding(map_osm.getCenter().lat, map_osm.getCenter().lng)
    //TODO améliorations
        //toggle du bouton
        //toggle pointeur sur carte + event listen clic gauche
        //onclickgauche > reversegeocodingPopup + toggle inverse bouton & pointeur
}
async function reverseGeocoding(lat, lon) {
    const resultat = await nominatimRequest("https://nominatim.openstreetmap.org/reverse?format=jsonv2&lat=" + lat + "&lon=" + lon)
    const texte = "<b>Coordonnées :</b><br>" + lat + ", " + lon + "<br><b>Adresse :</b><br>" + resultat.display_name
    afficherPopup(lat, lon, texte)
}