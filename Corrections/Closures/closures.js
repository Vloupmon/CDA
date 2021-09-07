
function additionner(a){
    
    return function(y) { 
      return  a = a + y;
      };
};

var closure = additionner(0);
console.log(closure);
console.log(closure(3));
console.log(closure(10));


// function increment() {
//     var i = 0;
//     console.log("Entrée dans la fonction")
//     return function() {
//         return i++;
//     }
// }
// var closureIncrement = increment();
// console.log(closureIncrement());
// console.log(closureIncrement());
// console.log(closureIncrement());
// var closureIncrement2 = increment();
// console.log("closure 2 : " + closureIncrement2());
// console.log("closure 2 : " + closureIncrement2());

// var nombre = 0;

// function afficherNombre (e){
//     return function(){ window.setTimeout(function() {
//         window.alert("valeur du nombre : " + e);
//     }, 2000);
//     };
// }
// var closureNombre = afficherNombre(nombre);
// closureNombre();
// nombre++;

var nombre = 0;

(function afficherNombre (e){
     window.setTimeout(function() {
        window.alert("valeur du nombre : " + e);
    }, 2000);
   
})(nombre);

nombre++;
