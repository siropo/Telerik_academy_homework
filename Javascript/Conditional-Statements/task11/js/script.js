//**************************************************
//
// Javascript homework
// Lecture Conditional-Statements
// author Viktor Ivanov
// date: 10.08.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 11
//**************************************************

function numToText() {

    var number = document.numbers.choise.value,
        output = document.numbers.printArea;

    if ((number < 0) || (number > 999)) {
        output.value = "please enter valid number";
    } else if ((!parseInt(number)) && (number != 0)) {
        output.value = "please enter valid number";
    } else {
        printNumber(number, output);
    }
}

function printNumber(num, output) {

    var output = document.numbers.printArea;

    console.log(num);

    var dg = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
    var tn = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];
    var tw = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

    num = num.toString();
    var array1 = num.split("");
    var arrLen = array1.length;

    if (arrLen == 1) {
        if (array1[0] == "0") {
            output.value = "//task 11: zero";
        } else {
            output.value = "//task 11: " + dg[array1[0]];
        }
    }

    if (arrLen == 2) {
        if (array1[0] == 1) {
            output.value = "//task 11: " + tn[array1[1]];
        }
        if ((array1[0] >= 2) && (array1[0] <= 9)) {
            output.value = "//task 11: " + tw[array1[0]] + " " + dg[array1[1]];
        }
    }

    if (arrLen == 3) {
        console.log(arrLen + "arrLen");
        console.log(array1[0] + array1[1] + array1[2] + "arrays");
        if ((array1[1] == 0) && (array1[2] == 0)) {
            output.value = "//task 11: " + dg[array1[0]] + " hundred ";
        }
        if ((array1[1] == 0) && (array1[2] > 0)) {
            output.value = "//task 11: " + dg[array1[0]] + " hundred " + dg[array1[2]];
        }
        if (array1[1] == 1) {
            output.value = "//task 11: " + dg[array1[0]] + " hundred " + tn[array1[2]];
        }
        if ((array1[1] >= 2) && (array1[1] <= 9)) {
            output.value = "//task 11: " + dg[array1[0]] + " hundred " + tw[array1[1]] + " " + dg[array1[2]];
        }
    }
}

//**************************************************
