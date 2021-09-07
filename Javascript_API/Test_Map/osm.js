/* constantes */
const mapboxToken = "pk.eyJ1IjoibWFwYm94IiwiYSI6ImNpejY4NXVycTA2emYycXBndHRqcmZ3N3gifQ.rJcFIG214AriISLbB6B5aw"
L.MakiMarkers.accessToken = mapboxToken
const couleur = {
    orange: "#ea9320",
    bleu: "#3559e8"
}
let markers = []

const map_osm = L.map('map_osm');
const popup = L.popup();
let mapbox_street, mapbox_sat, osm, osmfr, watercolor, landscape, outdoor, pioniers;
let layerMaps, layerMapsArray, favoris, surCouche;
let selectedLayer = 0, radioLayers;
let latitude = 45.158655;
let longitude = 1.532803;
let zoom = 16;
let zoomMax = 20;
let listeBookmarks = chargerBookmarks() || [];

$('#btnValid').click(chargerCoordonnees);
$('#btnFavori').click(ajouterBookmark);
$('.titreAnim').click(animationClick);
map_osm.on('contextmenu', informationsClick);
map_osm.on('moveend', majInputsCoords);

/* chargement initial */
chargerLayers();
chargementLayerControl();
chargementCarte();
chargementRadioButtons();
afficherTableauBookmarks();

/* mise en place carte */
function chargerCoordonnees() {
    latitude = parseFloat($('#lat').val());
    longitude = parseFloat($('#lon').val());
    zoom = parseInt($('#zoom').val());
    setCoordonnees();
}
function setCoordonnees() {
    if ($('.map .repliable').attr('data-isVisible') == 'false') {
        $('.map .titreAnim').triggerHandler('click');
    }
    map_osm.setView([latitude, longitude], zoom);
}
function animationClick() {
    const pannel = $(this).siblings('.repliable');
    const svg = $(this).parent().children('svg');
    pannel.slideToggle(1000);
    if ($(svg).css('transform') == 'matrix(-1, 0, 0, -1, 0, 0)') {
        $(svg).css('transform', 'rotate(0deg)');
        $(pannel).attr('data-isVisible', 'false');
    }
    else {
        $(svg).css('transform', 'rotate(180deg)');
        $(pannel).attr('data-isVisible', 'true');
    }
}
function chargerLayers() {
    mapbox_street = L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.jpg90?access_token={accessToken}', {
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery © <a href="https://www.mapbox.com/">Mapbox</a>',
        maxZoom: zoomMax,
        id: 'mapbox.streets',
        accessToken: mapboxToken
    });
    mapbox_sat = L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.jpg80?access_token={accessToken}', {
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery © <a href="https://www.mapbox.com/">Mapbox</a>',
        maxZoom: zoomMax,
        id: 'mapbox.satellite',
        accessToken: mapboxToken
    });
    osm = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: zoomMax,
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>'
    });
    osmfr = L.tileLayer('https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png', {
        maxZoom: zoomMax,
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>'
    });
    watercolor = L.tileLayer('http://{s}.tile.stamen.com/watercolor/{z}/{x}/{y}.png', {
        maxZoom: zoomMax,
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>'
    });
    landscape = L.tileLayer('https://tile.thunderforest.com/landscape/{z}/{x}/{y}.png?apikey={token}', {
        maxZoom: zoomMax,
        token: '7c352c8ff1244dd8b732e349e0b0fe8d',
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>'
    });
    outdoor = L.tileLayer('https://tile.thunderforest.com/outdoors/{z}/{x}/{y}.png?apikey={token}', {
        maxZoom: zoomMax,
        token: '7c352c8ff1244dd8b732e349e0b0fe8d',
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>'
    });
    pioniers = L.tileLayer('https://tile.thunderforest.com/pioneer/{z}/{x}/{y}.png?apikey={token}', {
        maxZoom: zoomMax,
        token: '7c352c8ff1244dd8b732e349e0b0fe8d',
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>'
    });
}
function chargementLayerControl() {
    layerMaps = {
        "MapBox Streets": mapbox_street,
        "MapBox Satellite": mapbox_sat,
        "OSM Classic": osm,
        "OSM France": osmfr,
        "WaterColor": watercolor,
        "Landscape": landscape,
        "Outdoors": outdoor,
        "Far West": pioniers
    };
    layerMapsArray = [
        mapbox_street,
        mapbox_sat,
        osm,
        osmfr,
        watercolor,
        landscape,
        outdoor,
        pioniers
    ]
}
function chargementCarte() {
    setCoordonnees();
    mapbox_street.addTo(map_osm);
    L.control.layers(layerMaps).addTo(map_osm);
}
function chargementRadioButtons() {
    radioLayers = document.getElementsByClassName('leaflet-control-layers-selector')
    for (let i = 0; i < radioLayers.length; i++) {
        radioLayers[i].setAttribute('data-radioLayerID', i)
    }
    for (const radioBtn of radioLayers) {
        radioBtn.addEventListener("change", radioControlCheck)
    }
}

/* intéractivité avec la carte */
async function informationsClick(e) {
    const clickLat = e.latlng.lat
    const clickLon = e.latlng.lng
    await reverseGeocoding(clickLat, clickLon)
}
function afficherPopup(latPopUp, lonPopUp, texte) {
    popup.setLatLng([latPopUp, lonPopUp])
        .setContent(texte)
        .openOn(map_osm);
}
function afficherMarker(latMarker, lonMarker, couleur, texte="") {
    const marker = L.marker();
    const iconColor = L.MakiMarkers.icon({
        icon: null,
        color: couleur
      });
    marker.setLatLng([latMarker, lonMarker]).setIcon(iconColor).addTo(map_osm)
    marker.bindPopup(texte);
    markers.push(marker)
}
function majInputsCoords() {
    $('#lat').val(map_osm.getCenter().lat);
    $('#lon').val(map_osm.getCenter().lng);
    $('#zoom').val(map_osm.getZoom());
}
function radioControlCheck(e) {
    selectedLayer = e.srcElement.dataset.radiolayerid
}

/*  Partie Bookmarks  */
class Bookmark {
    constructor(alias, lat, lon, zoom, layer) {
        this.alias = alias;
        this.lat = lat;
        this.lon = lon;
        this.zoom = zoom;
        this.layer = layer;
    }
}
function ajouterBookmark() {
    const alias = prompt("Entrez un titre pour ce favori :")
    if (alias != null) {
        const bookmark = new Bookmark(alias, map_osm.getCenter().lat, map_osm.getCenter().lng,map_osm.getZoom(), selectedLayer);
        listeBookmarks.push(bookmark)
        miseajourBookmarks()
    }
}
function miseajourBookmarks() {
    localStorage.setItem("geo_bookmarks", JSON.stringify(listeBookmarks));
    afficherTableauBookmarks()
}
function chargerBookmarks() {
    return JSON.parse(localStorage.getItem("geo_bookmarks"));
}
function afficherTableauBookmarks() {
    const tabFavori = document.getElementById("tabFavori")
    tabFavori.innerHTML = ""
    for (let i = 0; i < listeBookmarks.length; i++) {
        tabFavori.innerHTML += "<tr><td>" + listeBookmarks[i].alias + "</td><td><input type=\"button\" class=\"favDisplay\" data-id=\"" + i + "\" value=\"Afficher\"></td><td><input type=\"button\" class=\"favRename\" data-id=\"" + i + "\" value=\"Renommer\"></td><td><input type=\"button\" class=\"favDelete\" data-id=\"" + i + "\" value=\"Supprimer\"></td></tr>";
    }
    const btnsDisplay = document.getElementsByClassName("favDisplay")
    for (let element of btnsDisplay) {
        element.addEventListener("click", afficherBookmarkCarte);
    }
    const btnsDelete = document.getElementsByClassName("favDelete")
    for (let element of btnsDelete) {
        element.addEventListener("click", supprimerBookmark);
    }
    const btnsRename = document.getElementsByClassName("favRename")
    for (let element of btnsRename) {
        element.addEventListener("click", renomerBookmark);
    }
}
function afficherBookmarkCarte(e) {
    const bookmarkID = e.currentTarget.getAttribute("data-id")
    const bookmark = listeBookmarks[bookmarkID]
    latitude = bookmark.lat
    longitude = bookmark.lon
    zoom = bookmark.zoom
    setCoordonnees();
    changerLayerCarte(layerMapsArray[bookmark.layer]);
    afficherPopup(latitude, longitude, bookmark.alias)
}
function renomerBookmark(e) {
    const bookmarkID = e.currentTarget.getAttribute("data-id")
    const nouveauNom = prompt("Entrez un nouveau nom pour ce favori :")
    listeBookmarks[bookmarkID].alias = nouveauNom
    miseajourBookmarks()
}
function supprimerBookmark(e) {
    const bookmarkID = e.currentTarget.getAttribute("data-id")
    listeBookmarks.splice(bookmarkID,1)
    miseajourBookmarks()
}
function changerLayerCarte(nouveauLayer = osmfr) {
    map_osm.eachLayer(function(layer){
        map_osm.removeLayer(layer)
    })
    nouveauLayer.addTo(map_osm)
    chargementRadioButtons()
}

//TODO
//layer surcouche avec tous les bookmarks
//position user avec locate()
//recherche nominatim > superposition layer svg ?