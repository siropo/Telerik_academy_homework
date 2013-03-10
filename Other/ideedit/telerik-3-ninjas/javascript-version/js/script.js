//**************************************************
//
// Telerik academy challenge
// author Viktor Ivanov
// date: 21.11.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//Telerik ninjas
//**************************************************

// addEventListener
function addEventHandler(oNode, sEvt, fFunc, bCaptures) {
    if (oNode.addEventListener) {
        oNode.addEventListener(sEvt, fFunc, bCaptures);
    } else {
        oNode.attachEvent("on" + sEvt, fFunc);
    }
}

// Shape Class
function Shape() {
    
    this.x = 0;
    this.y = 0;
    this.id = "ninjas";
    this.fillColor = "black";
    this.strokeColor = "black";
    this.strokeWidth = 2;
    this.element = document.getElementById(this.id);
    this.canvasCtx = this.element.getContext("2d");
    this.ctxWidth = this.element.width;
    this.cxtHeight = this.element.height;

    this.fillShape = function () {
        this.canvasCtx.fillStyle = this.fillColor;
        this.canvasCtx.fill();
    }

    this.fillStroke = function () {
        this.canvasCtx.strokeStyle = this.strokeColor;
        this.canvasCtx.lineWidth = this.strokeWidth;
        this.canvasCtx.stroke();
    }

    this.drawShape = function () {
        this.canvasCtx.beginPath();
    }

    this.saveCtx = function () {
        this.canvasCtx.save();
    }

    this.restoreCtx = function () {
        this.canvasCtx.restore();
    }

    this.ctxTranslate = function (w, h) {
        this.canvasCtx.translate(w, h);
    }

    this.ctxRotate = function (r) {
        this.canvasCtx.rotate(r);
    }

    this.moveLine = function (x, y) {
        this.canvasCtx.moveTo(x, y);
    }

    this.drawLine = function (x, y) {
        this.canvasCtx.lineTo(x, y);
    }

    this.endDraw = function () {
        this.canvasCtx.closePath();
    }

    this.clearCtx = function (x, y, w, h) {
        this.canvasCtx.clearRect(x, y, w, h);
    }
}

// Arc Class
CanvasArc.prototype = new Shape();
CanvasArc.prototype.constructor = CanvasArc;

function CanvasArc() {

    Shape.apply(this, arguments);

    this.radius = 50;
    this.startAngle = 0;
    this.endAngle = Math.PI * 2;
    this.anticlockwise = true;

    

    this.drawShape = function () {
        this.canvasCtx.beginPath();
        this.canvasCtx.arc(this.x, this.y, this.radius, this.startAngle, this.endAngle, this.anticlockwise);
    }
}

// Bezier Class
CanvasBezier.prototype = new Shape();
CanvasBezier.prototype.constructor = CanvasBezier;

function CanvasBezier() {

    Shape.apply(this, arguments);

    this.startPoint = function () {
        this.canvasCtx.beginPath();
        this.canvasCtx.moveTo(this.x, this.y);
    }

    this.drawShape = function (cp1x, cp1y, cp2x, cp2y, x, y) {
        this.canvasCtx.bezierCurveTo(cp1x, cp1y, cp2x, cp2y, x, y);
    }
}

//----------------------------------------------------------------------------------
// Setup scene draw
//----------------------------------------------------------------------------------

function animationLoop() {
    draw();
    update();
}

// First Ninja positions
var firstNinjaX = 100;
var firstNinjaY = 100;

var secondNinjaX = firstNinjaX + 160;
var secondNinjaY = firstNinjaY;

var thirdNinjaX = firstNinjaX + 320;
var thirdNinjaY = firstNinjaY;

var birdX = firstNinjaX + 305;
var birdY = firstNinjaY - 1;

var moveFirstNEyesX = 0;
var moveFirstNEyesY = 0;

var moveSecondNEyesX = 0;
var moveSecondNEyesY = 0;

var moveThirdNEyesX = 0;
var moveThirdNEyesY = 0;

function draw() {

    var redrawScene = new Shape();
    redrawScene.clearCtx(0, 0, 515,250);
    //firstNinjaWrap.fillShape();
    
    var firstNinjaHead = new CanvasArc();
    firstNinjaHead.x = firstNinjaX;
    firstNinjaHead.y = firstNinjaY;
    firstNinjaHead.fillColor = "#000";
    firstNinjaHead.radius = 41;
    firstNinjaHead.drawShape();
    firstNinjaHead.fillShape();
    
    var firstNinjaFace = new Shape();
    firstNinjaFace.strokeColor = "#fff";
    firstNinjaFace.drawShape();
    firstNinjaFace.moveLine(firstNinjaX - 50, firstNinjaY + 8);
    firstNinjaFace.drawLine(firstNinjaX + 12, firstNinjaY + 8);
    firstNinjaFace.strokeWidth = 8;
    firstNinjaFace.fillStroke();
    firstNinjaFace.endDraw();

    var firstNinjaWrap = new CanvasArc();
    firstNinjaWrap.x = firstNinjaX;
    firstNinjaWrap.y = firstNinjaY;
    firstNinjaWrap.strokeWidth = 34;
    firstNinjaWrap.strokeColor = "#bfd630";
    firstNinjaWrap.radius = 57;
    firstNinjaWrap.drawShape();
    firstNinjaWrap.fillStroke();

    var firstNinjaRibbon = new CanvasBezier();
    firstNinjaRibbon.x = firstNinjaX + 20;
    firstNinjaRibbon.y = firstNinjaY - 25;
    firstNinjaRibbon.strokeColor = "black";
    firstNinjaRibbon.startPoint();
    firstNinjaRibbon.drawShape(firstNinjaRibbon.x - 2, firstNinjaRibbon.y - 2, firstNinjaRibbon.x + 10, firstNinjaRibbon.y - 20, firstNinjaRibbon.x + 12, firstNinjaRibbon.y - 15);
    firstNinjaRibbon.drawShape(firstNinjaRibbon.x + 10, firstNinjaRibbon.y + 10, firstNinjaRibbon.x + 2, firstNinjaRibbon.y + 2, firstNinjaRibbon.x - 2, firstNinjaRibbon.y);
    firstNinjaRibbon.drawShape(firstNinjaRibbon.x + 21, firstNinjaRibbon.y - 12, firstNinjaRibbon.x + 15, firstNinjaRibbon.y - 16, firstNinjaRibbon.x + 28, firstNinjaRibbon.y - 14);
    firstNinjaRibbon.drawShape(firstNinjaRibbon.x + 18, firstNinjaRibbon.y + 6, firstNinjaRibbon.x - 18, firstNinjaRibbon.y, firstNinjaRibbon.x - 5, firstNinjaRibbon.y + 10);
    firstNinjaRibbon.fillShape();
    firstNinjaRibbon.fillStroke();
    firstNinjaRibbon.endDraw();

    var firstNinjaREyes = new CanvasArc();
    firstNinjaHead.x = firstNinjaX + 5;
    firstNinjaHead.y = firstNinjaY + 11 - moveFirstNEyesY;
    firstNinjaHead.fillColor = "#000";
    firstNinjaHead.radius = 3;
    firstNinjaHead.drawShape();
    firstNinjaHead.fillShape();

    var firstNinjaLEyes = new CanvasArc();
    firstNinjaLEyes.x = firstNinjaX - 34;
    firstNinjaLEyes.y = firstNinjaY + 11 - moveFirstNEyesY;
    firstNinjaLEyes.fillColor = "#000";
    firstNinjaLEyes.radius = 3;
    firstNinjaLEyes.drawShape();
    firstNinjaLEyes.fillShape();

    // second ninjas

    var secondNinjaHead = new CanvasArc();
    secondNinjaHead.x = secondNinjaX;
    secondNinjaHead.y = secondNinjaY;
    secondNinjaHead.fillColor = "#000";
    secondNinjaHead.radius = 41;
    secondNinjaHead.drawShape();
    secondNinjaHead.fillShape();

    var secondNinjaFace = new Shape();
    secondNinjaFace.strokeColor = "#fff";
    secondNinjaFace.drawShape();
    secondNinjaFace.moveLine(secondNinjaX - 30, secondNinjaY);
    secondNinjaFace.drawLine(secondNinjaX + 30, secondNinjaY);
    secondNinjaFace.strokeWidth = 8;
    secondNinjaFace.fillStroke();
    secondNinjaFace.endDraw();

    var secondNinjaWrap = new CanvasArc();
    secondNinjaWrap.x = secondNinjaX;
    secondNinjaWrap.y = secondNinjaY;
    secondNinjaWrap.strokeWidth = 34;
    secondNinjaWrap.strokeColor = "#f1592a";
    secondNinjaWrap.radius = 57;
    secondNinjaWrap.drawShape();
    secondNinjaWrap.fillStroke();

    var secondNinjaRibbon = new CanvasBezier();
    secondNinjaRibbon.x = secondNinjaX + 20;
    secondNinjaRibbon.y = secondNinjaY - 25;
    secondNinjaRibbon.strokeColor = "black";
    secondNinjaRibbon.startPoint();
    secondNinjaRibbon.drawShape(secondNinjaRibbon.x - 2, secondNinjaRibbon.y - 2, secondNinjaRibbon.x + 10, secondNinjaRibbon.y - 20, secondNinjaRibbon.x + 12, secondNinjaRibbon.y - 15);
    secondNinjaRibbon.drawShape(secondNinjaRibbon.x + 10, secondNinjaRibbon.y + 10, secondNinjaRibbon.x + 2, secondNinjaRibbon.y + 2, secondNinjaRibbon.x - 2, secondNinjaRibbon.y);
    secondNinjaRibbon.drawShape(secondNinjaRibbon.x + 21, secondNinjaRibbon.y - 12, secondNinjaRibbon.x + 15, secondNinjaRibbon.y - 16, secondNinjaRibbon.x + 28, secondNinjaRibbon.y - 14);
    secondNinjaRibbon.drawShape(secondNinjaRibbon.x + 18, secondNinjaRibbon.y + 6, secondNinjaRibbon.x - 18, secondNinjaRibbon.y, secondNinjaRibbon.x - 5, secondNinjaRibbon.y + 10);
    secondNinjaRibbon.fillShape();
    secondNinjaRibbon.fillStroke();
    secondNinjaRibbon.endDraw();

    var secondNinjaHead = new CanvasArc();
    secondNinjaHead.x = secondNinjaX + 5;
    secondNinjaHead.y = secondNinjaY + 11;
    secondNinjaHead.fillColor = "#000";
    secondNinjaHead.radius = 3;
    secondNinjaHead.drawShape();
    secondNinjaHead.fillShape();

    var secondNinjaREyes = new Shape();
    secondNinjaREyes.strokeColor = "#000";
    secondNinjaREyes.drawShape();
    secondNinjaREyes.moveLine(secondNinjaX - 25, secondNinjaY - moveSecondNEyesY);
    secondNinjaREyes.drawLine(secondNinjaX - 17, secondNinjaY - moveSecondNEyesY);
    secondNinjaREyes.strokeWidth = 3;
    secondNinjaREyes.fillStroke();
    secondNinjaREyes.endDraw();

    var secondNinjaLEyes = new Shape();
    secondNinjaREyes.strokeColor = "#000";
    secondNinjaREyes.drawShape();
    secondNinjaREyes.moveLine(secondNinjaX + 25, secondNinjaY - moveSecondNEyesY);
    secondNinjaREyes.drawLine(secondNinjaX + 17, secondNinjaY - moveSecondNEyesY);
    secondNinjaREyes.strokeWidth = 3;
    secondNinjaREyes.fillStroke();
    secondNinjaREyes.endDraw();

    var secondNinjamouth = new CanvasBezier();
    secondNinjamouth.x = secondNinjaX;
    secondNinjamouth.y = secondNinjaY + 30;
    secondNinjamouth.strokeColor = "#fff";
    secondNinjamouth.startPoint();
    secondNinjamouth.drawShape(secondNinjamouth.x + 5, secondNinjamouth.y, secondNinjamouth.x + 10, secondNinjamouth.y, secondNinjamouth.x + 20, secondNinjamouth.y - 10);
    secondNinjamouth.fillStroke();

    secondNinjamouth.startPoint();
    secondNinjamouth.fillColor = "#ed217c";
    secondNinjamouth.moveLine(secondNinjamouth.x + 10, secondNinjamouth.y - 2);
    secondNinjamouth.drawShape(secondNinjamouth.x + 11, secondNinjamouth.y + 3, secondNinjamouth.x + 19, secondNinjamouth.y + 3, secondNinjamouth.x + 18, secondNinjamouth.y - 6);
    secondNinjamouth.fillShape();

    // Third ninja

    var thirdNinjaHead = new CanvasArc();
    thirdNinjaHead.x = thirdNinjaX;
    thirdNinjaHead.y = thirdNinjaY;
    thirdNinjaHead.fillColor = "#000";
    thirdNinjaHead.radius = 41;
    thirdNinjaHead.drawShape();
    thirdNinjaHead.fillShape();

    var thirdNinjaFace = new Shape();
    thirdNinjaFace.strokeColor = "#fff";
    thirdNinjaFace.drawShape();
    thirdNinjaFace.moveLine(thirdNinjaX - 30, thirdNinjaY - 8);
    thirdNinjaFace.drawLine(thirdNinjaX + 30, thirdNinjaY - 8);
    thirdNinjaFace.strokeWidth = 8;
    thirdNinjaFace.fillStroke();
    thirdNinjaFace.endDraw();

    var thirdNinjaWrap = new CanvasArc();
    thirdNinjaWrap.x = thirdNinjaX;
    thirdNinjaWrap.y = thirdNinjaY;
    thirdNinjaWrap.strokeWidth = 34;
    thirdNinjaWrap.strokeColor = "#00adef";
    thirdNinjaWrap.radius = 57;
    thirdNinjaWrap.drawShape();
    thirdNinjaWrap.fillStroke();

    var thirdNinjaRibbon = new CanvasBezier();
    thirdNinjaRibbon.x = thirdNinjaX + 20;
    thirdNinjaRibbon.y = thirdNinjaY - 25;
    thirdNinjaRibbon.strokeColor = "black";
    thirdNinjaRibbon.startPoint();
    thirdNinjaRibbon.drawShape(thirdNinjaRibbon.x - 2, thirdNinjaRibbon.y - 2, thirdNinjaRibbon.x + 10, thirdNinjaRibbon.y - 20, thirdNinjaRibbon.x + 12, thirdNinjaRibbon.y - 15);
    thirdNinjaRibbon.drawShape(thirdNinjaRibbon.x + 10, thirdNinjaRibbon.y + 10, thirdNinjaRibbon.x + 2, thirdNinjaRibbon.y + 2, thirdNinjaRibbon.x - 2, thirdNinjaRibbon.y);
    thirdNinjaRibbon.drawShape(thirdNinjaRibbon.x + 21, thirdNinjaRibbon.y - 12, thirdNinjaRibbon.x + 15, thirdNinjaRibbon.y - 16, thirdNinjaRibbon.x + 28, thirdNinjaRibbon.y - 14);
    thirdNinjaRibbon.drawShape(thirdNinjaRibbon.x + 18, thirdNinjaRibbon.y + 6, thirdNinjaRibbon.x - 18, thirdNinjaRibbon.y, thirdNinjaRibbon.x - 5, thirdNinjaRibbon.y + 10);
    thirdNinjaRibbon.fillShape();
    thirdNinjaRibbon.fillStroke();
    thirdNinjaRibbon.endDraw();

    var thirdNinjaREyes = new CanvasArc();
    thirdNinjaREyes.x = thirdNinjaX + 22;
    thirdNinjaREyes.y = thirdNinjaY - 10 + moveThirdNEyesY;
    thirdNinjaREyes.fillColor = "#000";
    thirdNinjaREyes.radius = 3;
    thirdNinjaREyes.drawShape();
    thirdNinjaREyes.fillShape();

    var thirdNinjaLEyes = new CanvasArc();
    thirdNinjaLEyes.x = thirdNinjaX - 22;
    thirdNinjaLEyes.y = thirdNinjaY - 10 + moveThirdNEyesY;
    thirdNinjaLEyes.fillColor = "#000";
    thirdNinjaLEyes.radius = 3;
    thirdNinjaLEyes.drawShape();
    thirdNinjaLEyes.fillShape();

    // Bird body

    var birdBody = new CanvasArc();
    birdBody.x = birdX + 10;
    birdBody.y = birdY - 48;
    birdBody.fillColor = "#f5ed30";
    birdBody.radius = 7;
    birdBody.drawShape();
    birdBody.fillShape();

    var birdHead = new CanvasArc();
    birdHead.x = birdX + 17;
    birdHead.y = birdY - 50;
    birdHead.fillColor = "#f5ed30";
    birdHead.radius = 4;
    birdHead.drawShape();
    birdHead.fillShape();
    birdHead.fillColor = "#000";
    birdHead.radius = 1;
    birdHead.drawShape();
    birdHead.fillShape();

    var birdNeb = new Shape();
    birdNeb.fillColor = "#f5ed30";
    birdNeb.strokeWidth = 1;
    birdNeb.drawShape();

    birdNeb.moveLine(birdX + 20, birdY - 48);
    birdNeb.drawLine(birdX + 23, birdY - 40);
    birdNeb.drawLine(birdX + 17, birdY - 48);
    birdNeb.fillShape();

    var birdLegs = new Shape();
    birdLegs.strokeColor = "#f5ed30";
    birdLegs.strokeWidth = 1;
    birdLegs.drawShape();
    // left leg
    birdLegs.moveLine(birdX + 7, birdY - 47);
    birdLegs.drawLine(birdX + 4, birdY - 35);
    birdLegs.drawLine(birdX, birdY - 35);
    birdLegs.moveLine(birdX + 4, birdY - 35);
    birdLegs.drawLine(birdX + 6, birdY - 32);
    birdLegs.moveLine(birdX + 4, birdY - 35);
    birdLegs.drawLine(birdX + 8, birdY - 36);
    // right leg
    birdLegs.moveLine(birdX + 11, birdY - 46);
    birdLegs.drawLine(birdX + 12, birdY - 35);
    birdLegs.moveLine(birdX + 12, birdY - 35);
    birdLegs.drawLine(birdX + 10, birdY - 33);
    birdLegs.moveLine(birdX + 13, birdY - 35);
    birdLegs.drawLine(birdX + 15, birdY - 36);
    birdLegs.fillStroke();

}

function update() {
    // First ninjas eyes
    if (birdX > 65 && birdX < 120 && birdY - 50 > 20 && birdY - 50 < 80) {
        if (moveFirstNEyesY == 6) {
            moveFirstNEyesY = 6;
        } else {
            moveFirstNEyesY += 1;
        }
    } else {
        if (moveFirstNEyesY == 0) {
            moveFirstNEyesY = 0;
        } else {
            moveFirstNEyesY -= 1;
        }
    }

    // second ninjas eyes
    if (birdX > 220 && birdX < 270 && birdY - 50 > 20 && birdY - 50 < 80) {
        if (moveSecondNEyesY == 3) {
            moveSecondNEyesY = 3;
        } else {
             moveSecondNEyesY += 1;
        }
    } else {
        if (moveSecondNEyesY == 0) {
            moveSecondNEyesY = 0;
        } else {
            moveSecondNEyesY -= 1;
        }
    }

    // third ninjas eyes
    if (birdX > 380 && birdX < 450 && birdY - 50 > 20 && birdY - 50 < 80) {
        if (moveThirdNEyesY == 0) {
            moveThirdNEyesY = 0;
        } else {
            moveThirdNEyesY -= 1;
        }
    } else {
        if (moveThirdNEyesY == 4) {
            moveThirdNEyesY = 4;
        } else {
            moveThirdNEyesY += 1;
        }
    }
}

addEventHandler(window, "keydown", function (e) {
    var keyCode = e.keyCode;
    // Left arrow key
    if (keyCode == 37) {
        birdX -= 5;
    }
    // Right arrow key
    if (keyCode == 39) {
        birdX += 5;
    }
    // Space
    if (keyCode == 38) {
        birdY -= 5;
    }

    if (keyCode == 40) {
        birdY += 5;
    }
}, false);

addEventHandler(window, "load", function () { setInterval(animationLoop, 30); }, false);

//************************************************* */