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
//task 1
//**************************************************

(function () {

    var draggedItem = null;
    var catId = 0;
    var score = 0;
    var gameLevel = 1;
    var timer = setInterval(function () { generateCats(1); }, 1200);

    function addEventHandler(oNode, sEvt, fFunc, bCaptures) {
        if (oNode.addEventListener) {
            oNode.addEventListener(sEvt, fFunc, bCaptures);
        } else {
            oNode.attachEvent("on" + sEvt, fFunc);
        }
    }

    function printResult(el, result) {
        var textToPrint = document.getElementById(el);
        textToPrint.innerHTML = result;
    }

    function generateCats(newCat) {
        catId += 1;
        var catsNodeArray = document.getElementById('cats-place').childNodes;
        var catInStage = catsNodeArray.length;
        var catProgress = catsNodeArray.length * 5;
        var catProgressBar = document.getElementById("cat-progress");
        catProgressBar.setAttribute("style", "width:" + catProgress + "px;");

        if (catProgress == 100) {
            clearInterval(timer);
            printResult("game-over", "Game Over");
        }

        if (catId == 25) {
            clearInterval(timer);
            gameLevel = 2;
            timer = setInterval(function () { generateCats(1); }, 900);
        } else if (catId == 50) {
            gameLevel = 3;
            clearInterval(timer);
            timer = setInterval(function () { generateCats(1); }, 700);
        }

        printResult("game-level", gameLevel);
        printResult("cats-count", catProgress);

        var cat = document.createElement("div");
        cat.className = "cat";
        cat.id = "cat" + catId;
        cat.setAttribute("draggable", "true");
        document.getElementById('cats-place').appendChild(cat);

        var x = Math.round(Math.random() * 600);
        var y = Math.round(Math.random() * 400);
        var styleString = "top:" + y + "px; left:" + x + "px;";

        cat.setAttribute("style", styleString);
        addEventHandler(cat, "dragstart", drag);

    }

    function init() {
        var trashBin = document.getElementById('trash');
        addEventHandler(trashBin, "drop", drop, false);
        addEventHandler(trashBin, "dragover", allowDrop, false);
        addEventHandler(trashBin, "dragleave", dragLeave, false);
    }

    function allowDrop(ev) {
        ev.preventDefault();
        this.className = 'opened';
    }

    function drag(ev) {
        draggedItem = ev.target;
        ev.dataTransfer.setData("trash", draggedItem.id);
    }

    function dragLeave(ev) {
        this.className = 'closed';
    }

    function drop(ev) {
        if (draggedItem !== null) {
            draggedItem.parentNode.removeChild(draggedItem);
        }
        this.className = 'closed';
        score += 1;
        printResult("score-bar", score);
    }

    addEventHandler(window, "load", init, false);
    addEventHandler(window, "load", function () {  timer; }, false);
})();

//************************************************* */