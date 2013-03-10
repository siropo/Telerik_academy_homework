//**************************************************
//
// Javascript homework
// Lecture Loops
// author Viktor Ivanov
// date: 14.13.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 3
//**************************************************

function printNum() {

    var nStr = document.getElementById("num").value;
    var result = document.getElementById("result");
    result.innerHTML = "";

    var numbers = nStr.split(","); 

    console.log(numbers);

    var max = numbers[0];
    var min = numbers[0];

    for (var i = 0; i < numbers.length; i++) {
        if (max < parseInt(numbers[i])) {
            max = numbers[i];
        }
        if (min > parseInt(numbers[i])) {
            min = numbers[i];
        }
    }

    result.innerHTML = min + " - min<br />" + max + " - max<br />";
}

//**************************************************