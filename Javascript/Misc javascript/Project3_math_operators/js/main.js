function addIt() {
  var A = 5, B = 7;
  var sum = A + B;
  var finalSum = sum.toString()
  document.getElementById("add").innerHTML = finalSum;
  subtractIt();
}


function subtractIt() {
  var A = 5, B = 7;
  var sum = A - B;
  var finalSum = sum.toString()
  document.getElementById("subtract").innerHTML = finalSum;
  multiplyIt();
}


function multiplyIt() {
  var A = 5, B = 7;
  var sum = A * B;
  var finalSum = sum.toString()
  document.getElementById("multiply").innerHTML = finalSum;
  divideIt();
}

function divideIt() {
  var A = 5, B = 7;
  var sum = A / B;
  var finalSum = sum.toString()
  document.getElementById("divide").innerHTML = finalSum;
  incrementPlusIt();
}

function incrementPlusIt() {
  var A = 5;
  var sum = A++;
  var finalSum = sum.toString()
  document.getElementById("incrementPlus").innerHTML = finalSum;
  incrementMinusIt();
}

function incrementMinusIt() {
  var A = 5;
  var sum = A--;
  var finalSum = sum.toString()
  document.getElementById("incrementMinus").innerHTML = finalSum;
  remainderIt();
}

function remainderIt() {
  var A = 5, B = 7;
  var sum = A % B;
  var finalSum = sum.toString()
  document.getElementById("remainder").innerHTML = finalSum;
  randomIt();
}

function randomIt() {

  document.getElementById("random").innerHTML = Math.random() * 100;

}