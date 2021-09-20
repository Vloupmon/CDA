// Déclaration de variables 
const mailRegex = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

const france = {
    country: 'France',
    postCode: /^(([0-8][0-9])|(9[0-5]))[0-9]{3}$/,
    phone: /^(\+33|0033|0)[0-8][0-9]{8}$/
};
const spain = {
    country: 'España',
    postCode: /^(?:0[1-9]|[1-4]\d|5[0-2])\d{3}$/,
    phone: /^34\s?(?:6[0-9]|7[1-9])[0-9]\s?[0-9]{3}\s?[0-9]{3}$/
};
const bearn = {
    country: 'Bearn',
    postCode: /^(64)[0-9]{3}$/,
    phone: /^(\+33|0033|0)(5|6|7)[0-9]{8}$/
};
const uk = {
    country: 'United Kingdom',
    postCode: /^([A-Z]{1,2}\d[A-Z\d]? ?\d[A-Z]{2}|GIR ?0A{2})$/,
    phone: /^((\+44)|(0)) ?\d{4} ?\d{6}$/
};
const italy = {
    country: 'Italia',
    postCode: /^\d{5}$/,
    phone: /^(\((00|\+)39\)|(00|\+)39)?(38[890]|34[7-90]|36[680]|33[3-90]|32[89])\d{7}$/
};

const pays = [france, spain, bearn, uk, italy];

var cb = document.getElementById("selPays");
for(let i = 0; i < pays.length; i++){
    var option = document.createElement("option");
    option.text = pays[i].country;
    cb.add(option);
}