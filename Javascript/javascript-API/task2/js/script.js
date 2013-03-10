//**************************************************
//
// Javascript homework
// Lecture API
// author Viktor Ivanov
// date: 11.11.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 2
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
    this.id = "head";
    //this.myShape = document.getElementById(this.id).getContext("2d"); ???
    this.fillColor = "black";
    this.strokeColor = "black";
    this.strokeWidth = 2;

    this.fillShape = function () {
        this.myShape.fillStyle = this.fillColor;
        this.myShape.fill();
    }
    this.fillStroke = function () {
        this.myShape.strokeStyle = this.strokeColor;
        this.myShape.lineWidth = this.strokeWidth;
        this.myShape.stroke();
    }
    this.drawShape = function () {
        
    }
    this.endDraw = function () {
        this.myShape.closePath();
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
        this.myShape = document.getElementById(this.id).getContext("2d");
        this.myShape.beginPath();
        this.myShape.arc(this.x, this.y, this.radius, this.startAngle, this.endAngle, this.anticlockwise);
    }
}

// Bezier Class
CanvasBezier.prototype = new Shape();
CanvasBezier.prototype.constructor = CanvasBezier;

function CanvasBezier() {

    Shape.apply(this, arguments);

    this.startPoint = function () {
        this.myShape = document.getElementById(this.id).getContext("2d");
        this.myShape.beginPath();
        this.myShape.moveTo(this.x, this.y);
    }

    this.drawShape = function (cp1x, cp1y, cp2x, cp2y, x, y) {
        this.myShape.bezierCurveTo(cp1x, cp1y, cp2x, cp2y, x, y);
    }
}

//----------------------------------------------------------------------------------
// Setup scene draw
//----------------------------------------------------------------------------------

// left apple eye position
var appleLeftEyeX = 202;
var appleLeftEyeY = 256;

// Hat position
var hatX = 180;
var hatY = 90;

function animationLoop() {
    draw();
    update();
}

function draw() {
    
    // draw head
    var Head = new CanvasArc();

    Head.x = 230;
    Head.y = 238;
    Head.radius = 68;
    Head.fillColor = "#f8f8cb";
    Head.strokeColor = "#727283";
    Head.drawShape();
    Head.fillStroke();
    Head.fillShape();
    Head.endDraw();

    // draw eyes
    // draw left eye

    var leftEye = new CanvasArc();
    leftEye.x = 202;
    leftEye.y = 238;
    leftEye.fillColor = "black";
    leftEye.radius = 12;
    leftEye.startAngle = 1.1 * Math.PI;
    leftEye.endAngle = 1.8 * Math.PI;
    leftEye.drawShape();
    leftEye.fillShape();
    leftEye.endDraw();

    // draw right eye

    var rightEye = new CanvasArc();
    rightEye.x = 256;
    rightEye.y = 238;
    rightEye.fillColor = "black";
    rightEye.startAngle = 1.3 * Math.PI;
    rightEye.endAngle = 1.9 * Math.PI;
    rightEye.radius = 12;
    rightEye.drawShape();
    rightEye.fillShape();
    rightEye.endDraw();

    // draw apple of the left eye

    var appleLeftEye = new CanvasArc();
    appleLeftEye.fillColor = "white";
    appleLeftEye.x = appleLeftEyeX;
    appleLeftEye.y = 240;
    appleLeftEye.radius = 4;
    appleLeftEye.drawShape();
    appleLeftEye.fillShape();
    appleLeftEye.endDraw();

    // draw apple of the right eye

    var appleRightEye = new CanvasArc();
    appleRightEye.fillColor = "white";
    appleRightEye.x = appleLeftEyeY;
    appleRightEye.y = 240;
    appleRightEye.radius = 4;
    appleRightEye.drawShape();
    appleRightEye.fillShape();
    appleRightEye.endDraw();

    // draw nose (cX1,cY1, cX2, cY2, x, y)

    var nose = new CanvasBezier();
    nose.x = 228;
    nose.y = 232;
    nose.strokeColor = "black";
    nose.startPoint();
    // 228, 235, 225, 265, 225, 265
    nose.drawShape(nose.x, nose.y, nose.x - 3, nose.y + 30, nose.x - 3, nose.y + 30);
    // 205, 280, 240, 285, 240, 270
    nose.drawShape(nose.x - 23, nose.y + 45, nose.x + 12, nose.y + 50, nose.x + 12, nose.y + 35);
    nose.fillStroke();
    nose.endDraw();

    // draw mount (cX1,cY1, cX2, cY2, x, y)

    var mount = new CanvasBezier();
    mount.x = 200;
    mount.y = 280;
    mount.strokeColor = "#3b3b3b";
    mount.fillColor = "black";
    mount.startPoint();
    mount.drawShape(200, 305, 260, 305, 260, 280);
    mount.drawShape(260, 290, 200, 290, 200, 280);
    mount.fillShape();
    mount.fillStroke();
    mount.lineWei
    mount.endDraw();

    // draw Hat(cX1,cY1, cX2, cY2, x, y) X = 180; Y = 90;

    var hatBottom = new CanvasBezier();
    hatBottom.x = hatX - 60; // hatBottom.x = 120
    hatBottom.y = hatY + 110; // hatBottom.y = 200
    hatBottom.fillColor = "#3b3b3b";
    hatBottom.startPoint(); // (cX1,cY1, cX2, cY2, x, y)
    // 120, 220, 340, 220, 340, 200
    hatBottom.drawShape(hatX - 60, hatY + 130, hatX + 160, hatY + 130, hatX + 160, hatY + 110);
    // 340, 180, 120, 180, 120, 200
    hatBottom.drawShape(hatX + 160, hatY + 90, hatX - 60, hatY + 90, hatX - 60, hatY + 110);
    hatBottom.fillShape();
    hatBottom.endDraw();

    // X = 180; Y = 90;

    var hatMiddle = new CanvasBezier();
    hatMiddle.x = hatX; // hatMiddle.x = 180
    hatMiddle.y = hatY + 110; // hatMiddle.y = 200
    hatMiddle.fillColor = "#222222";
    hatMiddle.strokeColor = "#2a2a2a";
    hatMiddle.startPoint();
    // 180, 208, 280, 208, 280, 200
    hatMiddle.drawShape(hatX, hatY + 118, hatX + 100, hatY + 118, hatX + 100, hatY + 110);
    // 280, 90, 280, 90, 280, 90
    hatMiddle.drawShape(hatX + 100, hatY, hatX + 100, hatY, hatX + 100, hatY);
    // 280, 87, 180, 87, 180, 90
    hatMiddle.drawShape(hatX + 100, hatY - 3, hatX + 100, hatY - 3, hatX, hatY);
    // 180, 90, 180, 90, 180, 200
    hatMiddle.drawShape(hatX, hatY, hatX, hatY, hatX, hatY + 110);
    hatMiddle.fillShape();
    hatMiddle.fillStroke();
    hatMiddle.endDraw();

    var hatTop = new CanvasBezier();
    hatTop.x = hatX; // hatTop.x = 180
    hatTop.y = hatY; // hatTop.y = 90
    hatTop.fillColor = "#3b3b3b";
    hatTop.strokeColor = "#2a2a2a";
    hatTop.startPoint();
    // 180, 100, 280, 100, 280, 90
    hatTop.drawShape(hatX, hatY + 10, hatX + 100, hatY + 10, hatX + 100, hatY);
    // 280, 80, 180, 80, 180, 90
    hatTop.drawShape(hatX + 100, hatY - 10, hatX, hatY - 10, hatX, hatY);
    hatTop.fillShape();
    hatMiddle.fillStroke();
    hatTop.endDraw();
}


// Set up eye animation
var moveleftEye = true;

function update() {
      
    if (appleLeftEyeX >= 196 && moveleftEye == true) {
        appleLeftEyeX += 1;
        appleLeftEyeY += 1;
    }

    if (appleLeftEyeX == 210 || moveleftEye == false) {
        moveleftEye = false
        if (appleLeftEyeX >= 198 || moveleftEye == false) {
            appleLeftEyeX -= 1;
            appleLeftEyeY -= 1;
            if (appleLeftEyeX == 196) {
                moveleftEye = true;
            }
        }
    }
}

addEventHandler(window, "load", function () { setInterval(animationLoop, 80); }, false);

//************************************************* */