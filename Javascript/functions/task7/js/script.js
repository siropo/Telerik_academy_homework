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
//task 7
//**************************************************

function flipNum() {

    var arrNum = document.getElementById("num-n").value;

    var getLengthN = arrNum.length;
    var result = document.getElementById("result");
    result.innerHTML = " ";

    for (var i = getLengthN - 1; i >= 0; i--) {
        result.innerHTML += arrNum[i];
    }

}

//************************************************* */