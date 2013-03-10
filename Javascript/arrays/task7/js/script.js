//**************************************************
//
// Javascript homework
// Lecture Arrays
// author Viktor Ivanov
// date: 18.10.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 7
//**************************************************

function binarySearch() {
    
    var nStr = document.getElementById("num-n").value;
    var kStr = document.getElementById("num-k").value;
    var nNum = parseInt(nStr);
    var arrayN = kStr.split(",");
    var high = arrayN.length;
    var result = document.getElementById("result");
    result.innerHTML = "";
    var temp;
    var low = 0;
    var arrNumbers = parseNum(arrayN);
    var found = false;
    // Parse elements in array to numbers
    var arrSort = sortNum(arrNumbers, high);
    // Sorting Array using selection sort algorithm

    while (low < high) {
        temp = Math.floor((low + high) / 2);
        //console.log(" arrtemp = " + arrayN[temp] + " temp is " + temp);
        if (arrayN[temp] === nNum) {
            found = arrayN[temp];
            break;
        } else if (nNum < arrayN[temp]) {
            high = temp;
            //console.log("high is " + high);
        } else {
            low = temp + 1;
            //console.log("temp is " + temp);
            //console.log("low is " + low);
        }
    }
    if (found) {
        result.innerHTML = "Found " + found;
    } else {
        result.innerHTML = "No number found";
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


//************************************************* */