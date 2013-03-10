//**************************************************
//
// Javascript homework
// Lecture Arrays
// author Viktor Ivanov
// date: 16.13.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 2
//**************************************************

function checkArr() {

    var nStr = document.getElementById("num-n").value;
    var arrayN = nStr.split(",");

    var kStr = document.getElementById("num-k").value;
    var arrayK = kStr.split(",");

    console.log(arrayN, arrayK);

    var getLengthN = arrayN.length;
    var getLengthK = arrayK.length;

    console.log(getLengthN, getLengthK);
    if (getLengthN > getLengthK) {
        endLength = getLengthN;
    } else {
        endLength = getLengthK;
    }

    var result = document.getElementById("result");
    result.innerHTML = " ";
    var count = 0;
    
    for (var i = 0; i < endLength; i++) {
        for (var j = 0; j < endLength; j++) {
            console.log("arrayN is " + arrayN[i] + " arrayK is " + arrayK[j]);
            if (arrayN[i] == arrayK[j]) {
                
                result.innerHTML += arrayN[i] + "/ ";
                count++;
            }
        }
    }

    result.innerHTML += " Fount " + count + " matches";
    
}

//************************************************* */