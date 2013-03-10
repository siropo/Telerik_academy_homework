//**************************************************
//
// Javascript homework
// Lecture Loops
// author Viktor Ivanov
// date: 14.13.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 4
//**************************************************

function printNum() {

    var nStr = document.getElementById("num-n").value;
    var KStr = document.getElementById("num-k").value;

    var numN = parseInt(nStr);
    var numK = parseInt(KStr);

    var result = document.getElementById("result");
    result.innerHTML = "";

    var calc = numN;
    
    console.log(numN);
    console.log(numK);

    if (numN == numK) {
        result.innerHTML = "result is 1";
    } else if (!(numN > numK)) {
        result.innerHTML = "result is 0";
    } else {
        for (var i = numN - 1; i > numK; i--) {
            result.innerHTML += calc + " * " + i + " = ";
            calc *= i;
            console.log("i is " + i);
               
            }
        result.innerHTML += " " + calc;
    }
    
}

//**************************************************