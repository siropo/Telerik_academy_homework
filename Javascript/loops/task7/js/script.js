//**************************************************
//
// Javascript homework
// Lecture Loops
// author Viktor Ivanov
// date: 15.13.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 7
//**************************************************

function fibonacci() {

    var nStr = document.getElementById("num-n").value;

    var numN = parseInt(nStr);
    result.innerHTML = "0";

    numN = numN / 2;

    var fi = 1;
    var old = 0;
    var sum = 1;

    for (var i = 1; i <= numN; i++) {
        fi = old + fi;
        old = old + fi;
        result.innerHTML += ", " + fi;
        sum += fi;
        if (i < numN) {
            result.innerHTML += ", " + old;
            sum += old;
        }
    }

    result.innerHTML += "<br /> sum = " + (sum - 1);
}

//************************************************* */