let activePlayer = 'X'; //the user
let selectedSquares = []; //array of all selected squares, continually updated as squares get selected

function placeXOrO(squareNumber) { //function that directs either user input (X) or computer input (O)
    

    if (!selectedSquares.some(element => element.includes(squareNumber))) { //sees if particular square has been already selected

        let select = document.getElementById(squareNumber);

        if (activePlayer === 'X') {
                select.style.backgroundImage = 'url(images/x.png)'; //if X is the active player, they can place 'X' image on board
        }
        else {
                select.style.backgroundImage = 'url(images/o.png)'; //otherwise, its going to be the 'O' image that gets placed down by computer
        }

        selectedSquares.push(squareNumber + activePlayer); //we add more to the array as spots on the board get claimed by X and O

        checkWinConditions(); //each turn, we check to see if anybody has won.

        if (activePlayer === 'X') { //conditional controls the switchoff between players
            activePlayer = 'O';
        }
        else {
            activePlayer = 'X';
        }


        audio('./media/place.wav'); //sounds gets played upon placing X or O on board

        if (activePlayer === 'O') { //if its O's turn, user cannot click on board for a certain amount of time
            disableClick();
            setTimeout(function () { computersTurn();}, 1000);
        }
        return true;
    }
}


function checkWinConditions() { //every possible way X or O can win.  When one of these conditionals are fulfilled, the line drawing function gets called

    //X0 1 2 condition
    if (arrayIncludes('0X', '1X', '2X')) {drawWinLine(50, 100, 558, 100)}

    //X 3 4 5

    else if (arrayIncludes('3X', '4X', '5X')) {drawWinLine(50, 304, 558, 304)}


    //X 6 7 8

    else if (arrayIncludes('6X', '7X', '8X')) {drawWinLine(50, 508, 558, 508)}


    //X 0 3 6

    else if (arrayIncludes('0X', '3X', '6X')) {drawWinLine(100, 50, 100, 558)}


    //X 1 4 7

    else if (arrayIncludes('1X', '4X', '7X')) {drawWinLine(304, 50, 304, 558)}


    //X 2 5 8

    else if (arrayIncludes('2X', '5X', '8X')) {drawWinLine(508, 50, 508, 558)}


    //X 6 4 2

    else if (arrayIncludes('6X', '4X', '2X')) {drawWinLine(100, 508, 510, 90)}


    //X 0 4 8

    else if (arrayIncludes('0X', '4X', '8X')) {drawWinLine(100, 100, 520, 520)}


    //O 0 1 2

    else if (arrayIncludes('0O', '1O', '2O')) {drawWinLine(50, 100, 558, 100)}


    //O 3 4 5

    else if (arrayIncludes('3O', '4O', '5O')) {drawWinLine(50, 304, 558, 304)}


    //O 6 7 8

    else if (arrayIncludes('6O', '7O', '8O')) {drawWinLine(50, 508, 558, 508)}


    //O 0 3 6

    else if (arrayIncludes('0O', '3O', '6O')) {drawWinLine(100, 50, 100, 558)}


    //O 1 4 7

    else if (arrayIncludes('1O', '4O', '7O')) {drawWinLine(304, 50, 508, 558)}


    //O 2 5 8

    else if (arrayIncludes('2O', '5O', '8O')) {drawWinLine(508, 50, 508, 558)}


    //O 6 4 2

    else if (arrayIncludes('6O', '4O', '2O')) {drawWinLine(100, 508, 510, 90)}


    //O 0 4 8

    else if (arrayIncludes('0O', '4O', '8O')) {drawWinLine(100, 100, 520, 520)}


    else if (selectedSquares.length >= 9) { //but if none of the above happen, then its a tie 
        audio('./media/tie.mp3'); //a sound gets played when there's a tie
        setTimeout(function() {resetGame();}, 500); //the reset function gets called and we can start the game all over again
    }
}


function arrayIncludes(squareA, squareB, squareC) { //this function returns true if there is a victory.  it gets called upon by the above function in its 'if statements'
    const a = selectedSquares.includes(squareA);
    const b = selectedSquares.includes(squareB);
    const c = selectedSquares.includes(squareC);

    if (a === true && b === true && c === true) {return true;}
}


function computersTurn() { //when its the computer's turn, it will choose a random square -- per this function
            let success = false;

            let pickASquare;

            while (!success) {
                pickASquare = String(Math.floor(Math.random() * 9));

                if (placeXOrO(pickASquare)) {
                    placeXOrO(pickASquare);
                    success = true;
                }
            }
}


function disableClick() { //stops the end user from clicking on the game board during the computer's turn

    body.style.pointerEvents = 'none';
    setTimeout(function () { body.style.pointerEvents = 'auto';}, 1000);

}

function audio(audioURL) { //audio player, plays one of 3 sounds (tie sound, win sound, or placing X or O down sound)
    let audio = new Audio(audioURL);
    audio.play();
}

function drawWinLine(coordX1, coordY1, coordX2, coordY2) { //handles animation of a line drawn across 3 winning boxes
    const canvas = document.getElementById('win-lines');
    const c = canvas.getContext('2d');

    let x1 = coordX1, y1 = coordY1, x2 = coordX2, y2 = coordY2, x = x1, y = y1;

    function animateLineDrawing() {
        const animationLoop = requestAnimationFrame(animateLineDrawing);
        c.clearRect(0, 0, 608, 608);
        c.beginPath();
        c.moveTo(x1, y1);
        c.lineTo(x, y);
        c.lineWidth = 10;
        c.strokeStyle = 'rgba(70, 255, 33, .8)';
        c.stroke();

        if (x1 <= x2 && y1 <= y2) {
            if (x < x2) {x += 10;}
            if (y < y2) {y += 10;}
            if (x >= x2 && y >= y2) {cancelAnimationFrame(animationLoop);}
        }

        if (x1 <= x2 && y1 >= y2) {
            if (x < x2) { x += 10; }
            if (y > y2) { y -= 10; }
            if (x >= x2 && y <= y2) {cancelAnimationFrame(animationLoop);}
        }

    }

    function clear() { //clears the board between games
        const animationLoop = requestAnimationFrame(clear);
        c.clearRect(0, 0, 608, 608);
        cancelAnimationFrame(animationLoop);

    }

    disableClick();
    audio('./media/winGame.wav');
    animateLineDrawing();
    setTimeout(function () {clear(); resetGame(); }, 1000);

}

function resetGame() {  //completely starts the game over
    for (let i = 0; i < 9; i++) {
        let square = document.getElementById(String(i));
        square.style.backgroundImage = '';
    }

    selectedSquares = [];
}