//**************************************************
//
// Javascript homework
// Lecture API
// author Viktor Ivanov
// date: 13.11.2012
// editor: Visual Studio 2012
//
//**************************************************

//**************************************************
//task 3 Bike
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
    this.id = "canvas";
    this.fillColor = "black";
    this.strokeColor = "black";
    this.strokeWidth = 2;

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
        this.canvasCtx = document.getElementById(this.id).getContext("2d");
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
    this.element = document.getElementById(this.id);
    this.canvasCtx = this.element.getContext("2d");

    this.ctxWidth = this.element.width;
    this.cxtHeight = this.element.height;

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
        this.canvasCtx = document.getElementById(this.id).getContext("2d");
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

// Bike Positions
var bikePositionX = 150;
var bikePositionY = 280;

// Bike Positions
var leftWhellPosX = bikePositionX;
var leftWhellPosY = bikePositionY;

// Right whell
var rightWhellPosX;
var rightWhellPosY = bikePositionY;

// Inner bike speed
var bikeSpeed = 0;
var innerWhellMove = 0;

// Ball move
var ballPosX = bikePositionX + 670;
var ballPosY = bikePositionY + 30;

// Game score
var yourScore = 0;
var ballScore = 0;

function animationLoop() {
    draw();
    update();
}

function draw() {
    
    var canvasEl = document.getElementById("canvas");
    var canvasCtx = canvasEl.getContext("2d");

    // Clear scene
    canvasCtx.clearRect(0, 0, 800, 500);

    // Display score
    canvasCtx.font = '18px Tahoma';
    canvasCtx.textBaseline = 'top';
    canvasCtx.fillText("Wins - " + yourScore + " | Losses - " + ballScore,
    600, 0);

    // Create ball
    var ball = new CanvasArc();
    ball.x = ballPosX;
    ball.y = ballPosY;
    ball.radius = 10;
    ball.drawShape();
    ball.fillColor = "#ffd900";
    ball.fillShape();
    ball.fillStroke();
    ball.endDraw();

    // left Whell
    var leftWhell = new CanvasArc();
    leftWhell.strokeWidth = 7;
    leftWhell.x = bikePositionX;
    leftWhell.y = bikePositionY;
    leftWhell.radius = 40;
    leftWhell.drawShape();
    leftWhell.fillStroke();

    // Inner left Whell
    var innerLeftWhell = new CanvasArc();
    innerLeftWhell.x = bikePositionX;
    innerLeftWhell.y = bikePositionY;
    innerLeftWhell.fillColor = "gray";
    innerLeftWhell.radius = 10;
    innerLeftWhell.drawShape();
    innerLeftWhell.fillShape();

    // Start animation spire
    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(40, 0);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(35, 18);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(22, 36);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(0, 40);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(-22,36);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(-35,18);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(-40, 0);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(-35,-18);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(-22, -36);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(0, -40);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(22,-36);
    innerLeftWhell.restoreCtx();

    innerLeftWhell.saveCtx();
    innerLeftWhell.ctxTranslate(bikePositionX, bikePositionY);
    innerLeftWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerLeftWhell.moveLine(0, 0);
    innerLeftWhell.drawLine(36,-18);
    innerLeftWhell.restoreCtx()
    innerLeftWhell.fillStroke();
    innerLeftWhell.endDraw();

    // Position on all right whell parts
    rightWhellPosX = bikePositionX + 165;

    // Right Whell
    var rightWhell = new CanvasArc();
    rightWhell.strokeWidth = 7;
    rightWhell.x = bikePositionX + 165;
    rightWhell.y = bikePositionY;
    rightWhell.radius = 40;
    rightWhell.drawShape();
    rightWhell.fillStroke();
    rightWhell.endDraw();

    // Inner right Whell
    var innerRightWhell = new CanvasArc();
    innerRightWhell.x = rightWhellPosX;
    innerRightWhell.y = bikePositionY;
    innerRightWhell.fillColor = "gray";
    innerRightWhell.radius = 10;
    innerRightWhell.drawShape();
    innerRightWhell.fillShape();

    // Start animation spire
    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(40, 0);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(35,18);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(22, 36);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(0, 40);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(-22,36);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(-35,18);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(-40, 0);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(-35,-18);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(-22,-36);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(0,-40);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(22,-36);
    innerRightWhell.restoreCtx();

    innerRightWhell.saveCtx();
    innerRightWhell.ctxTranslate(rightWhellPosX, bikePositionY);
    innerRightWhell.ctxRotate(Math.PI / 180 * (innerWhellMove += bikeSpeed));
    innerRightWhell.moveLine(0, 0);
    innerRightWhell.drawLine(36, -18);
    innerRightWhell.restoreCtx();
    innerRightWhell.fillStroke();
    innerRightWhell.endDraw();

    // Bike body
    var bikeBody = new Shape();
    bikeBody.drawShape();
    bikeBody.strokeColor = "red";
    bikeBody.strokeWidth = 8;
    bikeBody.moveLine(bikePositionX, bikePositionY);
    bikeBody.drawLine(bikePositionX + 60, bikePositionY - 40);
    bikeBody.fillStroke();
    bikeBody.endDraw();

    bikeBody.drawShape();
    bikeBody.strokeWidth = 5;
    bikeBody.moveLine(bikePositionX + 2, bikePositionY - 1);
    bikeBody.drawLine(bikePositionX + 80, bikePositionY - 1);
    bikeBody.drawLine(bikePositionX + 40, bikePositionY - 80);

    bikeBody.moveLine(bikePositionX + 46, bikePositionY - 65);
    bikeBody.drawLine(bikePositionX + 130, bikePositionY - 70);
    bikeBody.fillStroke();
    bikeBody.endDraw();

    bikeBody.drawShape();
    bikeBody.strokeWidth = 10;
    bikeBody.moveLine(bikePositionX + 80, bikePositionY - 1);
    bikeBody.drawLine(bikePositionX + 140, bikePositionY - 90);
    bikeBody.fillStroke();
    bikeBody.endDraw();

    bikeBody.drawShape();
    bikeBody.strokeWidth = 6;
    bikeBody.moveLine(bikePositionX + 137, bikePositionY - 100);
    bikeBody.drawLine(bikePositionX + 165, bikePositionY);
    bikeBody.fillStroke();
    bikeBody.endDraw();

    // Bike pedals part 1
    var bikePedals1 = new CanvasArc();
    bikePedals1.x = bikePositionX + 80;
    bikePedals1.y = bikePositionY;
    bikePedals1.fillColor = "gray";
    
    bikePedals1.radius = 14;
    bikePedals1.drawShape();
    bikePedals1.strokeWidth = 2;
    bikePedals1.strokeColor = "#727283";
    bikePedals1.fillShape();
    bikePedals1.endDraw();
    bikePedals1.strokeColor = "#000";
    bikePedals1.moveLine(bikePositionX + 80, bikePositionY);
    bikePedals1.drawLine(bikePositionX + 100, bikePositionY + 10);
    bikePedals1.fillStroke();
    bikePedals1.endDraw();

    // Bike pedals part 2
    var bikePedals2 = new Shape();
    bikePedals2.drawShape();
    bikePedals2.strokeWidth = 6;
    bikePedals2.moveLine(bikePositionX + 90, bikePositionY + 10);
    bikePedals2.drawLine(bikePositionX + 108, bikePositionY + 10);
    bikePedals2.fillStroke();
    bikePedals2.endDraw();

    bikePedals2.drawShape();
    bikePedals2.strokeWidth = 1;

    bikePedals2.moveLine(bikePositionX + 80, bikePositionY + 14);
    bikePedals2.drawLine(bikePositionX, bikePositionY + 9);

    bikePedals2.moveLine(bikePositionX + 20, bikePositionY - 9);
    bikePedals2.drawLine(bikePositionX + 80, bikePositionY - 14);
    bikePedals2.fillStroke();
    bikePedals2.endDraw();
    
    // Create bike handles
    var handles = new Shape();
    handles.drawShape();
    handles.strokeWidth = 8;
    handles.moveLine(bikePositionX + 151, bikePositionY - 100);
    handles.drawLine(bikePositionX + 120, bikePositionY - 90);
    handles.fillStroke();
    handles.endDraw();
    handles.moveLine(bikePositionX + 152, bikePositionY - 98);
    handles.drawLine(bikePositionX + 120, bikePositionY - 110);
    handles.fillStroke();
    handles.endDraw();

    // Create seat handles
    var seat = new CanvasBezier();
    seat.x = bikePositionX + 20;
    seat.y = bikePositionY - 80;
    seat.strokeColor = "black";
    seat.startPoint();
    seat.drawShape(seat.x, seat.y, seat.x - 3, seat.y + 10, seat.x +40, seat.y - 5);
    seat.drawShape(seat.x, seat.y - 10, seat.x, seat.y - 10, seat.x, seat.y);
    seat.fillShape();
    seat.fillStroke();
    seat.endDraw();
}

// Set up update perimeters
var jumpBike = false;
var pass = true;
var lose = false;
var ballSpeed = 10;

function update() {
    if (jumpBike == true && bikePositionY > 180)
    {
        // Jump up 10px interval
        bikePositionY -= 10;
        if (bikePositionY == 180) {
            jumpBike = false;
        }
    }
    if (bikePositionY >= 180 && bikePositionY < 280 && jumpBike == false) {
        // Jump down 10px interval
        bikePositionY += 10;
        if (bikePositionY == 280) {
            bikePositionY = bikePositionY;
        }
    }
    
    if (ballPosX <= 820) {
        // Move ball right from left with custom ballSpeed
        ballPosX -= ballSpeed;
        if (ballPosX <= -320) {
            if (pass != false) {
                // Update win score
                yourScore += 1;
                if (ballSpeed < 26) {
                    // Increase ballspeed by 5 bx
                    ballSpeed += 5;
                }
            } else {
                // Update lose score
                ballScore += 1;
            }
            pass = true;
            ballPosX = 820;
        }
    }
    // Check position on ball and left and right whell positions
    if (bikePositionY + 30 == ballPosY && (rightWhellPosX - 5 == ballPosX || rightWhellPosX + 5 == ballPosX || rightWhellPosX == ballPosX)) {
        lose = true;
        pass = false;
    } else if (bikePositionY + 30 == ballPosY && (leftWhellPosX - 5 == ballPosX || leftWhellPosX + 5 == ballPosX || leftWhellPosX == ballPosX)) {
        lose = true;
        pass = false;
    }
}

addEventHandler(window, "keydown", function (e) {
    var keyCode = e.keyCode;
    // Left arrow key
    if (keyCode == 37) {
        bikePositionX -= 10;
        bikeSpeed = 1;
    }
    // Right arrow key
    if (keyCode == 39) {
        bikePositionX += 10;
        bikeSpeed = 9;
    }
    // Space
    if (keyCode == 32) {
        if (bikePositionY == 280) {
            jumpBike = true;
        }
        bikeSpeed = 9;
    }
}, false);

addEventHandler(window, "load", function () { setInterval(animationLoop, 40); }, false);

//************************************************* */