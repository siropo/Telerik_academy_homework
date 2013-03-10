//**************************************************
//
// Javascript homework
// Lecture Loops
// author Viktor Ivanov
// date: 10.13.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//Extra task 
//**************************************************

function printMatrix() {

    var n = parseInt(document.getElementById("num").value);
    var result = document.getElementById("result");

    if (n > 30) {
        result.innerHTML = " Please enter number < 30";
    } else {

        var arr = new Array();
        result.innerHTML = "";

        for (var i = 0; i < n; i++) {
            arr[i] = new Array();

            for (var j = i + 1 ; j <= n + i; j++) {
                arr[i][j] = j;
                result.innerHTML += "<div style='float:left; width: 15px;'>" + arr[i][j] + "</div>";
            }

            result.innerHTML += " <div style='clear: both;'></div>";

        }
        console.log(arr);
    }
}

//**************************************************