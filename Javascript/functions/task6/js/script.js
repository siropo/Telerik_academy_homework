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
//task 6
//**************************************************

function neighbors() {

    var arrNum = document.getElementById("arr").value;
        arrNum = arrNum.split(",");
        arrNum = parseNum(arrNum);

    var getLengthN = arrNum.length;
    var result = document.getElementById("result");
    result.innerHTML = " ";
    var found = false;

    for (var i = 0; i < getLengthN; i++) {
        if (arrNum[i] > arrNum[i - 1] && arrNum[i] > arrNum[i + 1]) {
            found = true;
            result.innerHTML += arrNum[i] + " is > " + arrNum[i - 1] + " and  " + arrNum[i + 1] + "/ ";
        }  
    }

    if (!found) {
        result.innerHTML += "false";
        return -1;
    }
}

function parseNum(parseArr) {
    for (a in parseArr) {
        parseArr[a] = parseInt(parseArr[a]);
    }
    return parseArr;
}



//************************************************* */