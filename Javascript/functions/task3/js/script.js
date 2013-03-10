//**************************************************
//
// Javascript homework
// Lecture Functions
// author Viktor Ivanov
// date: 28.10.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 3
//**************************************************

function lastDigit() {

    var aNum = parseInt(document.getElementById("num-a").value);
    var result = document.getElementById("result");
    var lastdigit = Math.floor(aNum % 10);
    var outputtxt;

    switch (lastdigit) {
        case 0:
            outputtxt = "zero";
            break;
        case 1:
            outputtxt = "one";
            break;
        case 2:
            outputtxt = "two";
            break;
        case 3:
            outputtxt = "tree";
            break;
        case 4:
            outputtxt = "four";
            break;
        case 5:
            outputtxt = "five";
            break;
        case 6:
            outputtxt = "six";
            break;
        case 7:
            outputtxt = "seven";
            break;
        case 8:
            outputtxt = "eigth";
            break;
        case 9:
            outputtxt = "nine";
            break;
        default:
            outputtxt = "Please enter number!";
    }

    result.innerHTML = outputtxt;
}


//************************************************* */