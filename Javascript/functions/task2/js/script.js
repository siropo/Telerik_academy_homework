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
//task 2
//**************************************************

function startGetMax() {

    var aNum = parseInt(document.getElementById("num-a").value);
    var bNum = parseInt(document.getElementById("num-b").value);
    var cNum = parseInt(document.getElementById("num-c").value);
    var result = document.getElementById("result");

    result.innerHTML = GetMax(GetMax(aNum, bNum), cNum);
}

function GetMax(a, b) {
    var max = a;

    if (max < b) {
        max = b;
    }
    return max;
}

//************************************************* */