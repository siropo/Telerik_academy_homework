//**************************************************
//
// Javascript homework
// Lecture Loops
// author Viktor Ivanov
// date: 15.13.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 5
//**************************************************

function fact() {

    var nStr = document.getElementById("num-n").value;
    var kStr = document.getElementById("num-k").value;

    var numN = parseInt(nStr);
    var numK = parseInt(kStr);

    var result = document.getElementById("result");
    result.innerHTML = "";

    var calcNK = numN - numK;

    if ((numN < 1) || (numK < 1)) {
        result.innerHTML += "Error! (1 < K < N)";
    } else if (numN < numK) {
        result.innerHTML += "Error! (1 < K < N)";
    } else if (isNaN(numN) || isNaN(numK)) {
        result.innerHTML += "Error! Enter number";
    } else {
        if (calcNK <= 0) {
            calcNK = 1;
        }

        result.innerHTML = " " + calcFact(numN, numK, calcNK);

    }
    
}

function calcFact(nFact, kFact, nkFact) {

    for (var i = nFact - 1; i > 0; i--) {
        
        nFact *= i;

        if (nFact == kFact) {
            kFact = nFact;
        } else if (i < kFact) {
            kFact *= i;
        }

        if (i < nkFact) {
            nkFact *= i;
        }

        console.log("i is " + i);

    }
    var calc = (nFact * kFact) / nkFact
    var result = " " + nFact + " * " + kFact + " / " + nkFact + " = " + calc;
   return  result;
}

//**************************************************