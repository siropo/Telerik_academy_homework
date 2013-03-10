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
//task 8
//**************************************************

function createArr(getLength) {
    var addArr = [];
    for (var i = 0; i < getLength; i++) {
        addArr[i] = 0;
    }
    return addArr;
}

function sum() {

    var nNum = document.getElementById("num-n").value;
    var kNum = document.getElementById("num-k").value;

    arrANum = nNum.split("");
    arrKNum = kNum.split("");

    arrANum = parseNum(arrANum);
    arrKNum = parseNum(arrKNum);

    arrANum.unshift(0);
    arrKNum.unshift(0);

    var getLengthANum = arrANum.length;
    var getLengthKNum = arrKNum.length;
    var maxLength = getLengthANum;
    var numSum;
    var tens = 0;

    if (getLengthANum != getLengthKNum) {

        var numLength = getLengthANum - getLengthKNum;
        var createNewArr;

        if (numLength < 0) {
            numLength = numLength * -1;
            createNewArr = createArr(numLength);
            arrANum = createNewArr.concat(arrANum);
            maxLength = getLengthKNum;
        } else {
            createNewArr = createArr(numLength);
            arrKNum = createNewArr.concat(arrKNum);
            maxLength = getLengthANum;
        }
    }
    
    var result = document.getElementById("result");
    result.innerHTML = " ";

    var arrSum = [];

    for (var i = maxLength - 1; i >= 0 ; i--) {

        var ones = (arrANum[i] + arrKNum[i]) % 10;
        arrSum[i] = ones + tens;
        tens = Math.floor((arrANum[i] + arrKNum[i]) / 10);
        if (arrSum[i] === 10) {
            arrSum[i] = 0;
            tens = 1;
        }
    }

    if (arrSum[0] !== 0) {
        result.innerHTML += arrSum[0];
    }

    for (var j = 1; j < arrSum.length; j++) {
            result.innerHTML += arrSum[j];
    }

}

function parseNum(parseArr) {
    for (a in parseArr) {
        parseArr[a] = parseInt(parseArr[a]);
    }
    return parseArr;
}

//************************************************* */