//**************************************************
//
// Javascript homework
// Lecture Loops
// author Viktor Ivanov
// date: 10.13.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 1
//**************************************************

function printNum() {

    var nStr = read("num");
    n = parseInt(nStr) + 1;
    var result = document.getElementById("result");
    result.innerHTML = "";

    for (var i = 1; i < n; i++) {
        result.innerHTML += i + " ";
    }

}

//**************************************************

