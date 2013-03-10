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
//task 1
//**************************************************

function createArr() {

    var nStr = document.getElementById("num-n").value;
    var numN = parseInt(nStr);

    var result = document.getElementById("result");
    result.innerHTML = "myArray =  myArray[";
    var myArray = new Array();
    var str = "";

    for (var i = 0; i < numN; i++) {
        myArray[i] = i * 5;
        result.innerHTML += str + myArray[i];
        str = ", ";
    }

    result.innerHTML += "]";
}

//************************************************* */