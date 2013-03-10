//**************************************************
//
// Javascript homework
// Lecture Arrays
// author Viktor Ivanov
// date: 23.10.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 6
//**************************************************

function maxSequence() {

    var nStr = document.getElementById("num-n").value;
    var nNum = parseInt(nStr);
    var arrayN = nStr.split(",");
    var getLengthN = arrayN.length;
    var result = document.getElementById("result");
    result.innerHTML = "";

    var arrNumbers = parseNum(arrayN);
    // Parse elements in array to numbers
    var arrSort = sortNum(arrNumbers, getLengthN);
    // Sorting Array using selection sort algorithm
    var searchLen = maxLen(arrSort, getLengthN);
    // Create Array for all length in sequance numbers
    var max = maxNumber(searchLen, getLengthN);
    // Find max number in sequance numbers in array

    if (max < 2) {
        result.innerHTML = "no result";
    } else {
        result.innerHTML = " max length is " + max + " in numbers ";
        for (var j = 0; j < getLengthN; j++) {
            if (searchLen[j] === max) {
                result.innerHTML += arrayN[j] + "/ ";
                // If found max number in searchLen display number in arrayN in this position;
            }
        }
    }
}

function sortNum(numArr, arrLen) {

    var tmp;
    var tmp2;

    for (var i = 0; i < arrLen; i++) {
        tmp = i;
        for (var j = i + 1; j < arrLen; j++) {
            if (numArr[j] < numArr[tmp]) {
                tmp = j;
            }
        }
        tmp2 = numArr[tmp];
        numArr[tmp] = numArr[i];
        numArr[i] = tmp2;
    }
    return numArr;
}

function parseNum(parseArr) {
    for (a in parseArr) {
        parseArr[a] = parseInt(parseArr[a]);
    }
    return parseArr;
}

function maxNumber(maxInArr, arrLen) {

    var max = maxInArr[0];

    for (var i = 0; i < arrLen; i++) {
        if (max < maxInArr[i]) {
            max = maxInArr[i];
        }
    }
    return max;
}

function maxLen(foundLen, arrLen) {

    var start = 1;
    var maxlen = 1;
    var maxArr = [];

    for (var i = 0; i < arrLen; i++) {
        if (foundLen[i] != foundLen[i - 1]) {
            maxlen = 1;
            maxArr[i] = maxlen;
        } else {
            start = i - maxlen;
            maxlen++;
            maxArr[i] = maxlen;

        }
    }
    return maxArr;
}

//************************************************* */