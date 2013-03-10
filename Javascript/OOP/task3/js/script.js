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
//task 3
//**************************************************

function addEventHandler(oNode, sEvt, fFunc, bCaptures) {
    if (oNode.addEventListener) {
        oNode.addEventListener(sEvt, fFunc, bCaptures);
    } else {
        oNode.attachEvent("on" + sEvt, fFunc);
    }
}

function setUpClickHandler(e) {
    addEventHandler(document.getElementById('rect-btn'), "click", calcRectSurface, false);
	addEventHandler(document.getElementById('triangle-btn'), "click", calcTriangleSurface, false);
	addEventHandler(document.getElementById('circle-btn'), "click", calcCircleSurface, false);
}

function printResult(result) {
	var textToPrint = document.getElementById("result");
	textToPrint.innerHTML = result;
}

function Shape(width, height) {
	
	this.width = width;
	this.height = height;
	
    this.calculateSurface = function () {
    }
}

Triangle.prototype = new Shape();
Triangle.prototype.constructor = Triangle;

function Triangle(width, height) {

	Shape.apply(this, arguments);
	
	this.calculateSurface = function () {
		return (this.height * this.width) / 2;
    }
    
}

Rectangle.prototype = new Shape();
Rectangle.prototype.constructor = Rectangle;

function Rectangle(width, height) {

	Shape.apply(this, arguments);
	
	this.calculateSurface = function () {
		return this.height * this.width;
    }
    
}

Circle.prototype = new Shape();
Circle.prototype.constructor = Circle;

function Circle(radius) {

	Shape.apply(this, arguments);
	
	this.width = radius;
	this.height = radius;
	
	this.calculateSurface = function () {
		return Math.PI * (this.width * this.height);
    }
}

function calcRectSurface() {

	var rectWidth = document.getElementById("rect-width").value;
	var rectHeight = document.getElementById("rect-height").value;
	
	var rectangle = new Rectangle(rectWidth, rectHeight);
	var resultSurface = rectangle.calculateSurface();
	
	return printResult("Rectangle surface is " + resultSurface);
}

function calcTriangleSurface() {

	var trWidth = document.getElementById("tr-width").value;
	var trHeight = document.getElementById("tr-height").value;

	var triangle = new Triangle(trWidth, trHeight);
	var resultSurface = triangle.calculateSurface();

    return printResult("Triangle surface is " + resultSurface);
}

function calcCircleSurface() {

	var circleWidth = document.getElementById("radius").value;
	
	var circle = new Circle(circleWidth);
	var resultSurface = circle.calculateSurface();

    return printResult("Circle surface is " + resultSurface);
}

addEventHandler(window, "load", setUpClickHandler, false);

//************************************************* */