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
//task 6
//**************************************************

function fact() {

    var nStr = document.getElementById("num-n").value;
    var kStr = document.getElementById("num-k").value;

    var numN = parseInt(nStr);
    var numX = parseInt(kStr);

    var s = 1;
    var fact = 1;
    var den = 1;
    var sum = "";

    var result = document.getElementById("result");
    result.innerHTML = "";

    for (var i = 1; i <= numN; i++) {
        fact *= i;
        den = den * numX;

        console.log(den + " ");

        s += (fact / den);

        sum += " + " + i + "!/" + den + "^" + i;
    }
    result.innerHTML = "S = 1" + sum + " = " + s;
}

//************************************************* */