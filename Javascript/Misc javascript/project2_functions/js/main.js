function myFunction() { //first function

    var A = "text part 1", B = " text part 2";
    document.getElementById("pgr").style.fontSize = "x-large"; //changes size
    document.getElementById("pgr").innerHTML = A + B; //combines strings
    mySecondFunction(); //calls second function below
  }

function mySecondFunction() { //second function
    var str = "I am learning a lot"; //declares variable
    str += " from this book."; //also concatenates
    document.getElementById("concatenate").innerHTML = str; //changes paragraph element to concatenated string
}