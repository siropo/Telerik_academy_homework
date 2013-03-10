//**************************************************
//
// Javascript homework
// Lecture Arrays
// author Viktor Ivanov
// date: 17.12.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 5
//**************************************************

function selectionSort() {

    var nStr = document.getElementById("num-n").value;
    var nNum = parseInt(nStr);
    var arrayN = nStr.split(",");

    for (a in arrayN) {
        arrayN[a] = parseInt(arrayN[a]);
    }

    var getLengthN = arrayN.length;
    var result = document.getElementById("result");
    result.innerHTML = "";

    var tmp;
    var tmp2;

    for (var i = 0; i < getLengthN; i++) {
        tmp = i;
        for (var j = i + 1; j < getLengthN; j++) {
            if (arrayN[j] < arrayN[tmp]) {
                tmp = j;
            }
        }
        tmp2 = arrayN[tmp];
        arrayN[tmp] = arrayN[i];
        arrayN[i] = tmp2;
        result.innerHTML += arrayN[i] + " ";
    }
}

//************************************************* */