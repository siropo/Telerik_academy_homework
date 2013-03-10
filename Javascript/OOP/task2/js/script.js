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
}

function createNewObj() {
    var yell = document.getElementById("yell").value;

    var result = document.getElementById("result");
    result.innerHTML = "";

    var resultYell = document.getElementById("result-yell");

    // Create objects for school subject and marks on 3 students
    var peshoMarks = {};
    peshoMarks.schoolSubject = "mathematics";
    peshoMarks.studentMarks = [2, 3, 5, 4];

    var goshoMarks = {};
    goshoMarks.schoolSubject = "physics";
    goshoMarks.studentMarks = [4, 5, 2, 5];

    var veskaMarks = {};
    veskaMarks.schoolSubject = "mathematics";
    veskaMarks.studentMarks = [5, 5, 6, 5];

    // Create 3 Student objects
    var peshoStudent = new Student("Pesho", "Male", "14B", "22998877", "PGMP", peshoMarks);
    var goshoStudent = new Student("Gosho", "Male", "30/A", "088776221", "PMG", goshoMarks);
    var veskaStudent = new Student("Veska", "Female", "11/A", "088776221", "PMG", veskaMarks);

    var kireChild = [peshoStudent, veskaStudent]
    var parentKire = new Parent("Kire", "Male", "29/A", "0899776655", kireChild);

    var sedefkaChild = [goshoStudent]
    var parentSedefka = new Parent("Sedefka", "Female", "21/A", "998877665", sedefkaChild);
   
    // Remove last masrk on student pesho and add new mark 33333
    peshoStudent.removeMark();
    peshoStudent.addMark(33333);

    // Print methods on Student class.
    result.innerHTML += peshoStudent.printArgStudent();
    result.innerHTML += goshoStudent.printArgStudent();
    result.innerHTML += veskaStudent.printArgStudent();

    // Call yell method on class Parent to yell on his student
    resultYell.innerHTML = parentKire.yell(yell);

    console.log(peshoStudent, goshoStudent, veskaStudent);
    console.log(parentKire, parentSedefka);
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

// inheriting Human and create class Student
Student.prototype = new Human();
Student.prototype.constructor = Student;

function Student(name, gender, address, tel, school, marks) {
    Human.apply(this, arguments);
    var self = this;
    var marksText = "";
    var addNewMark = "";

    self.schcool = school;
    self.marks = marks;

    // method to calc average mark on student
    self.averageMarks = function () {
        var sum = 0;
        var len = marks.studentMarks.length;
        for (var i = 0; i < len; i++) {
            sum += marks.studentMarks[i];
        }
        return sum / len;
    }

    // method to add new mark
    self.addMark = function (newMark) {
        addNewMark = newMark;
        marks.studentMarks.push(newMark);
        marksText += "Add new mark  " + addNewMark + "<br />";
    }

    // method to remove last mark
    self.removeMark = function () {
        var removeLast = marks.studentMarks[marks.studentMarks.length - 1];
        marks.studentMarks.pop();
        marksText += "Remove last mark " + removeLast + "<br />";
    }

    // method to print student arguments
    self.printArgStudent = function () {
        return "<div class='student left'>Student name: " + self.name + "!<br /> Student school: " + self.schcool + "!<br />" + 
          "School subject: " + self.marks.schoolSubject + "<br />" + "Student marks: " + self.marks.studentMarks + "<br />" +
        "Average mark: " + self.averageMarks() + "<br />" + marksText + "</div>";
    }

    return self;
}

// inheriting Human and create class Parent
Parent.prototype = new Human();
Parent.prototype.constructor = Parent;

function Parent(name, gender, address, tel, parentchild) {
    Human.apply(this, arguments);
    var self = this;
    self.parentChild = parentchild;

    // Yell method
    self.yell = function (childname) {
        var yell;
        for (var i = 0; i < parentchild.length; i++) {
            if (childname == parentchild[i].name) {
                yell = "Father yell " + parentchild[i].name;
                break;
            } else {
                yell = "No childs whit that name " + childname;
            }
        }
        return yell;
    }
    return self;
}


addEventHandler(window, "load", setUpClickHandler, false);

//************************************************* */