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
//task 1
//**************************************************

var a = 3;
var b = -2;
var c = 1;
var d = 12;
var f = 18;

if (a > b) {
    console.log("//task 1: a is larger than b");
}

//**************************************************

//**************************************************
//task 2
//**************************************************

if (a > 0) {
    if (b > 0) {
        if (d > 0) {
            console.log("//task 2: We have (+a +b +d) = +");
        } else {
            console.log("//task 2: sing is (+a +b -d) = +");
        }
    } else {
        if (d > 0) {
            console.log("//task 2: We have (+a -b +d) = +");
        } else {
            console.log("//task 2: sing is (+a -b -d) = -");
        }
    }
} else {
    if (b < 0) {
        if (d < 0) {
            console.log("//task 2: We have (-a -b -d) = -");
        } else {
            console.log("//task 2: We have (-a -b +d) = -");
        }
    } else {
        if (d < 0) {
            console.log("//task 2: We have (-a +b -d) = -");
        } else {
            console.log("//task 2: We have (-a +b +d) = +");
        }
    }
}

//**************************************************

//**************************************************
//task 3
//**************************************************


if ((a > b) || (b > c) || (c > a)) {
    if (a > c) {
        console.log("//task 3: a is most larger");
    } if (b > a) {
        if (b > c) {
            console.log("//task 3: b is most larger");
        }
    } if (c > b) {
        if (c > a) {
            console.log("//task 3: c is most larger");
        }
    }
}


//**************************************************

//**************************************************
//task 4
//**************************************************

if ((a > b) || (b > c) || (c > a)) {
    if (a > c) {
        if (b > c) {
            if (a > b) {
                console.log("//task 4: " + c + ", " + b + ", " + a);
            } else {
                console.log("//task 4: " + c + ", " + a + ", " + b);
            }
        } else {
            console.log("//task 4: " + b + ", " + c + ", " + a);
        }
    } if (b > a) {
        if (b > c) {
            if (c > a) {
                console.log("//task 4: " + a + ", " + c + ", " + b);
            }
        }
    } if (c > b) {
        if (c > a) {
            if (b > a) {
                console.log("//task 4: " + a + ", " + b + ", " + c);
            } else {
                console.log("//task 4: " + b + ", " + a + ", " + c);
            }
        }
    }
}


//**************************************************

//**************************************************
//task 5
//**************************************************

console.log("//task 5: use html form");

function numToText() {
    var num = document.getElementById('num_to_text');
    console.log(num.value);
    switch (num.value) {
        case "0":
            num.value = "zero";
            break;
        case "1":
            num.value = "one";
            break;
        case "2":
            num.value = "two";
            break;
        case "3":
            num.value = "three";
            break;
        case "4":
            num.value = "four";
            break;
        case "5":
            num.value = "five";
            break;
        case "6":
            num.value = "six";
            break;
        case "7":
            num.value = "seven";
            break;
        case "8":
            num.value = "eight";
            break;
        case "9":
            num.value = "nine";
            break;
        default: num.value = "0";
    }
}

//**************************************************

//**************************************************
//task 6
//**************************************************

console.log("//task 6: use html form");

function calcNum() {

    var num_a = document.getElementById('num1').value;
    var num_b = document.getElementById('num2').value;
    var num_c = document.getElementById('num3').value;
    var result = document.getElementById('result');

    var D = (num_b * num_b) - (4 * num_a * num_c);

    if (D < 0) {
        console.log("//task 6: D = " + D + " Уравнението няма реални корени!");
    } else if (D == 0) {
        var x = -num_b / (2 * num_a);
        if (isNaN(x)) {
            x = 0;
        }
        console.log("//task 6: D = " + D + ", x = " + x + ". Уравнението има един реален корен!");
    } else {
        var x1 = (-num_b + Math.sqrt((num_b * num_b) - (4 * num_a * num_c))) / (2 * num_a);
        var x2 = (-num_b - Math.sqrt((num_b * num_b) - (4 * num_a * num_c))) / (2 * num_a);
        console.log("//task 6: D = " + D + " Уравнението има два реални корена! x1 = " + x1 + ", x2 = " + x2);
    }

}

//**************************************************

//**************************************************
//task 7
//**************************************************

var max = 0;
var numbers = new Array(442, 15, 22, 124, 44);

for (var i = 0; i < numbers.length; i++) {
    if (max < numbers[i]) {
        max = numbers[i];
    }
}

console.log("//task 7: max number is " + max);

//**************************************************

//**************************************************
//task 8
//**************************************************

var chekVar = 11.4;
var typeChekVar = typeof (chekVar);

if (typeChekVar == "number") {
    chekVar++;
    chekVar = "number " + chekVar;
} else {
    chekVar = "string " + chekVar + "*";
}

console.log("//task 8: variable is " + chekVar);

//**************************************************

//**************************************************
//task 9
//**************************************************

var numbers2 = new Array(-2, 1, 4, 2, 8);

var sortNumbers = numbers2.sort(function (a, b) { return a - b });
var sum = 0;
var message = new Array;

for (var i2 = 0; i2 < numbers2.length; i2++) {
    sum = sum + sortNumbers[i2];
    message[i2] = sortNumbers[i2];
    if (sum == 0) {
        console.log("//task 9: zero found!" + message);
        break;
    }
}


//**************************************************

//**************************************************
//task 10
//**************************************************

var number3 = 7;

switch (number3) {
    case 1:
    case 2:
    case 3: console.log("//task 10: " + number3 * 10);
        break;
    case 4:
    case 5:
    case 6: console.log("//task 10: " + number3 * 100);
        break;
    case 7:
    case 8:
    case 9: console.log("//task 10: " + number3 * 1000);
        break;
    default: console.log("//task 10: " + "error");
}

//**************************************************

//**************************************************
//task 11
//**************************************************

var dg = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
var tn = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];
var tw = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

var number = 231;
number = number.toString();
var array1 = number.split("");
var arrLen = array1.length;

    if (arrLen == 1) {
         document.write("//task 11: " + dg[array1[0]]);
    }

    if (arrLen == 2) {
        if (array1[0] == 1) {
            document.write("//task 11: " + tn[array1[1]]);
        }
        if ((array1[0] >= 2) && (array1[0] < 9)) {
            document.write("//task 11: " + tw[array1[0]] + " " + dg[array1[1]] + "match");
        }
    }

    if (arrLen == 3) {
        if (array1[1] == 1) {
            document.write("//task 11: " + dg[array1[0]] + " hundred " + tn[array1[1]]);
        }
        if ((array1[1] >= 2) && (array1[1] < 9)) {
            document.write("//task 11: " + dg[array1[0]] + " hundred " + tw[array1[1]] + " " + dg[array1[2]]);
        }

    }


//**************************************************