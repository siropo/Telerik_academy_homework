//**************************************************
//
// Javascript homework
// Lecture Functions
// author Viktor Ivanov
// date: 28.10.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 1
//**************************************************

function printName() {

    var nStr = document.getElementById("num-n").value;
    var result = document.getElementById("result");

    if (!isNaN(nStr)) {
        result.innerHTML = "Please enter valid name!";
    } else {
        result.innerHTML = nStr;
    }

}

//************************************************* */