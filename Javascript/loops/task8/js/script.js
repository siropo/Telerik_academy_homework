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
//task 8
//**************************************************

function gcd() {

    var nStr = document.getElementById("num-n").value;
    var kStr = document.getElementById("num-k").value;
    var numN = parseInt(nStr);
    var numK = parseInt(kStr);
    var result = document.getElementById("result");
    var chkResult = 1;

    while (chkResult > 0) {
        chkResult = numN % numK;
        numN = numK;
        numK = chkResult;
        console.log(" chkResult = " + chkResult + " numK = " + numK + " numN = " + numN);
    }

    result.innerHTML = numN;
}

//************************************************* */