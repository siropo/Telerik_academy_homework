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
//task 4
//**************************************************

function findRepeatNum() {

    var aNum = parseInt(document.getElementById("num-a").value);
    var arrNum = document.getElementById("arr").value;
        arrNum = arrNum.split(",");
        arrNum = parseNum(arrNum);

    var getLengthN = arrNum.length;
    var result = document.getElementById("result");
    var count = 0;

    for (var i = 0; i < getLengthN; i++) {
        if (aNum === arrNum[i]) {
            count++;
        }
    }

    if (count === 0) {
        result.innerHTML = "Number not found!";
    } else {
        result.innerHTML = "Number " +  aNum + " found " + count + " times";
    }
}

function parseNum(parseArr) {
    for (a in parseArr) {
        parseArr[a] = parseInt(parseArr[a]);
    }
    return parseArr;
}



//************************************************* */