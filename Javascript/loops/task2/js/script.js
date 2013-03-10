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
//task 2
//**************************************************

function printNum() {

    var nStr = read("num");
    n = parseInt(nStr) + 1;
    var result = document.getElementById("result");
    result.innerHTML = "";

    for (var i = 1; i < n; i++) {
        if (((i % 3) == 0) && ((i % 7) == 0)) {
            result.innerHTML += i + " % 3 and 7 = 0 <br />";
        }
    }
}

//**************************************************