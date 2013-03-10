//**************************************************
//
// Javascript homework
// Lecture OOP
// author Viktor Ivanov
// date: 03.11.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 1
//**************************************************

function addEventHandler(oNode, sEvt, fFunc, bCaptures) {
    if (oNode.addEventListener) {
        oNode.addEventListener(sEvt, fFunc, bCaptures);
    } else {
        oNode.attachEvent("on" + sEvt, fFunc);
    }
}

function setUpClickHandler(e) {
    addEventHandler(document.getElementById('create-obj'), "click", createNewObj, false);
}

function createNewObj() {
    var name = document.getElementById("name").value;
    var gender = document.getElementById("gender").value;
    var address = document.getElementById("address").value;
    var tel = document.getElementById("tel").value;
    var result = document.getElementById("result");    
    
    if (name === "" || gender === "" ||
        address === "" || tel === "") {
        result.innerHTML = "Fill all fields!";
        return false;
    }

    // Create new human object
    var human1 = new Human(name, gender, address, tel);

    result.innerHTML = human1.printArg();
    console.log(human1);
}

function Human(name, gender, address, tel) {
    var self = this;
   
    self.name = name;
    self.gender = gender;
    self.address = address;
    self.tel = tel;
    self.printArg = function() {
        return "Hi I am " + self.name + "!<br />" + "My gender is " + self.gender + ".<br />" +
            "My address is " + self.address + ".<br />" + "Please call me on " + self.tel + ".";
    }
    return self;
}

addEventHandler(window, "load", setUpClickHandler, false);

//************************************************* */