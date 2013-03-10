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
//task 3
//**************************************************

function seqFound(len) {
    this.len = len;
}

function sequence() {
    var nStr = document.getElementById("num-n").value;
    var arrayN = nStr.split(",");

    var getLengthN = arrayN.length;
    var result = document.getElementById("result");
    result.innerHTML = "";

    var start = 1;
    var maxlen = 1;
    var maxArr = [];

    for (var i = 0; i < getLengthN; i++) {
        if (parseInt(arrayN[i + 1]) - parseInt(arrayN[i]) === 1) {
            start = i - maxlen;
            maxlen++;
            maxArr[i] = new seqFound(maxlen);
        } else {
            maxlen = 1;
            maxArr[i] = new seqFound(maxlen);
        }
    }
    getMaxSeq(maxArr, arrayN);
}

function getMaxSeq(getArrSeq, fisrtArr) {
    var temp = new Array();
    var maxLength = getArrSeq.length;
    
    for (var i = 0; i < maxLength; i++) {
        temp[i] = getArrSeq[i].len;
    }

    var max = Math.max.apply(Math, temp);
    if (max < 2) {
        result.innerHTML = "no result";
    } else {
        result.innerHTML = " max length is " + max + " in number ";
        var found = [];
        for (var j = 0; j < maxLength; j++) {
            if (temp[j] === max) {
                found.push(fisrtArr[j + 1]);
            }
        }
        for (var h = 0; h < found.length; h++) {
            var tempFound = (found[h] - max) + 1;
            result.innerHTML += "/ " + tempFound;
            for (var k = 1; k < max; k++) {
                tempFound++;
                result.innerHTML += " " + tempFound;
            }
        }
    }    
}

//************************************************* */