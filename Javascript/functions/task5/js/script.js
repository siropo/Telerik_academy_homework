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
//task 5
//**************************************************

function neighbors() {

    var aNum = parseInt(document.getElementById("num-a").value);
    var arrNum = document.getElementById("arr").value;
    arrNum = arrNum.split(",");
    arrNum = parseNum(arrNum);

    var getLengthN = arrNum.length;
    var result = document.getElementById("result");
    result.innerHTML = " ";

    if (aNum < 0 || aNum > getLengthN - 1) {
        result.innerHTML += "Out if Array";
    } else {
        if (aNum != 0) {
            if (arrNum[aNum] > arrNum[aNum - 1]) {
                result.innerHTML += arrNum[aNum] + " is > " + arrNum[aNum - 1] + " ";
            } else if (arrNum[aNum] < arrNum[aNum - 1]) {
                result.innerHTML += arrNum[aNum] + " is < " + arrNum[aNum - 1] + " ";
            } else {
                result.innerHTML += arrNum[aNum] + " is = " + arrNum[aNum - 1] + " ";
            }
        }
        if (aNum < getLengthN - 1) {
            if (arrNum[aNum] > arrNum[aNum + 1]) {
                result.innerHTML += arrNum[aNum] + " is > " + arrNum[aNum + 1];
            } else if (arrNum[aNum] < arrNum[aNum + 1]) {
                result.innerHTML += arrNum[aNum] + " is < " + arrNum[aNum + 1];
            } else {
                result.innerHTML += arrNum[aNum] + " is = " + arrNum[aNum + 1] + " ";
            }
        }
    }

}

function parseNum(parseArr) {
    for (a in parseArr) {
        parseArr[a] = parseInt(parseArr[a]);
    }
    return parseArr;
}



//************************************************* */