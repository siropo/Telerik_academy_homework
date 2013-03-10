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
        if (arrayN[i] != arrayN[i - 1]) {
            maxlen = 1;
            maxArr[i] = new seqFound(maxlen);
        } else {
            start = i - maxlen;
            maxlen++;
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

    var max = Math.max.apply(0, temp);
    if (max < 2) {
        result.innerHTML = "no result";
    } else {
        result.innerHTML = " max length is " + max + " in number ";
        for (var j = 0; j < maxLength; j++) {
            if (temp[j] === max) {
                result.innerHTML += fisrtArr[j] + "/ ";
            }
        }
    }
}

//************************************************* */