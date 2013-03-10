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
//task 2
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
    addEventHandler(document.getElementById('remove-marks'), "click", removeMarks, false);
    addEventHandler(document.getElementById('add-marks'), "click", addMarks, false);
}

function removeMarks() {
    peshoSchoolMarks.removeMark();
}

function addMarks() {
    peshoSchoolMarks.addMark(2);
}

// Parse all srting to numbers in array
function parseNum(parseArr) {
    for (a in parseArr) {
        parseArr[a] = parseInt(parseArr[a]);
    }
    return parseArr;
}

function createNewObj() {
    var name = document.getElementById("name").value;
    var gender = document.getElementById("gender").value;
    var address = document.getElementById("address").value;
    var tel = document.getElementById("tel").value;
    var schoolName = document.getElementById("school-name").value;
    var schoolSub = document.getElementById("school-subject").value;
    var marks = document.getElementById("marks").value;
        marks = marks.split(",");
        marks = parseNum(marks);

    var result = document.getElementById("result");

    
    /*if (name === "" || gender === "" ||
        address === "" || tel === "") {
        result.innerHTML = "Fill all fields!";
        return false;
    }*/

    // Create new human object
    var subjectMarks = {};
    subjectMarks.schoolSubject = schoolSub;
    subjectMarks.studentMarks = marks;

    var minchoMarks = {};
    minchoMarks.schoolSubject = "Matematika";
    minchoMarks.studentMarks = [4,5,2,5];

    var pesho = new Human(name, gender, address, tel);
    var peshoSchoolMarks = new Student(name, gender, address, tel, schoolName, subjectMarks);
    var mincho = new Student("Mincho", "Male", "30/A", "088776221", "PMG,", minchoMarks);
    var parentChild = [peshoSchoolMarks, mincho]
    var parentKire = new Parent("Kire", "Male", "29/A", "0899776655", parentChild);
   
    result.innerHTML = pesho.printArgHuman();
    result.innerHTML += peshoSchoolMarks.printArgStudent();
    result.innerHTML += peshoSchoolMarks.removeMark();
    result.innerHTML += peshoSchoolMarks.addMark(33333);
    result.innerHTML += peshoSchoolMarks.printArgStudent();
    result.innerHTML += parentKire.yell("Mincho");

    console.log(pesho);
    console.log(peshoSchoolMarks);
    console.log(parentKire);
}

function Human(name, gender, address, tel) {
    var self = this;
   
    self.name = name;
    self.gender = gender;
    self.address = address;
    self.tel = tel;
    self.printArgHuman = function () {
        return "Hi I am " + self.name + "!<br />" + "My gender is " + self.gender + ".<br />" +
            "My address is " + self.address + ".<br />" + "Please call me on " + self.tel + ".";
    }
    return self;
}

Student.prototype = new Human();
Student.prototype.constructor = Student;

function Student(name, gender, address, tel, school, marks) {
    Human.apply(this, arguments);
    var self = this;
   
    self.schcool = school;
    self.marks = marks;
    self.averageMarks = function () {
        var sum = 0;
        var len = marks.studentMarks.length;
        for (var i = 0; i < len; i++) {
            sum += marks.studentMarks[i];
        }
        return sum / len;
    }

    self.addMark = function (newMark) {
        var newPush = marks.studentMarks.push(newMark);
    }
    self.removeMark = function () {
        var removeArr = marks.studentMarks.pop();
    }

    self.printArgStudent = function () {
        return "<br />" + self.name + "! Hi I am school " + self.schcool + "!<br />" + "My marks is " + self.marks.studentMarks + ".<br />" +
        "Average " + self.averageMarks() + "<br />" + "Add new mark  " + self.addMark() + "<br />Remove mark  " + self.removeMark();
    }
    return self;
}

Parent.prototype = new Human();
Parent.prototype.constructor = Parent;

function Parent(name, gender, address, tel, parentchild) {
    Human.apply(this, arguments);
    var self = this;
    self.parentChild = parentchild;

    self.yell = function (childname) {
        var yell;
        for (var i = 0; i < parentchild.length; i++) {
            if (childname == parentchild[i].name) {
                yell = "Father yell" + parentchild[i].name;
            } else {
                yell = "No childs whit that name" + parentchild[i].name + childname + parentchild.length + parentchild[1].name;
            }
        }
        return yell;
    }
    return self;
}




addEventHandler(window, "load", setUpClickHandler, false);

//************************************************* */