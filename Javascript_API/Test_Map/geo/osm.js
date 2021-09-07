const map = L.map('map')
const layer = L.tileLayer(
    //http://a.tile.openstreetmap.fr/osmfr/${z}/${x}/${y}.png
    "https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png", {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
})
layer.addTo(map)
map.setView([45.15, 1.53], 12)

const txtMap = document.getElementById('txtMap')
const btnMap = document.getElementById('btnMap')

btnMap.addEventListener("click", onclickRecherche)

async function onclickRecherche() {
    const resultat = await fetchURL("https://nominatim.openstreetmap.org/?q="+encodeURIComponent(txtMap.value)+"&addressdetails=1&format=json")
    console.log(resultat)
    map.flyToBounds([
        [resultat[0].boundingbox[0], resultat[0].boundingbox[2]],
        [resultat[0].boundingbox[1], resultat[0].boundingbox[3]]
    ])
}
async function fetchURL(url) {
    const reponse = await fetch(url)
    const json = await reponse.json()
    return json
}