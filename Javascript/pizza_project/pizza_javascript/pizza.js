function getReceipt() { //when the order placing button gets pushed by user, this function gets launched
    var text1 = "<h3>You Ordered:</h3>"; //we begin constructing the string to summarize for the end user what they ordered
    var runningTotal = 0; //initialization of variables that we will use shortly
    var sizeTotal = 0;
    var sizeArray = document.getElementsByClassName("size");
    for (var i = 0; i < sizeArray.length; i++) { //loops through array declared one line above to find if it was 'checked' or not by user
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
            text1 = text1 + selectedSize + "<br>"; //appends the text1 variable
        }
    }
    if (selectedSize === "Personal Pizza") {  //series of conditional statements that decide how much the 'sizeTotal' variable will be, based on pizza size choice
        sizeTotal = 6;
    } else if (selectedSize == "Small Pizza") {
        sizeTotal = 8;
    } else if (selectedSize == "Medium Pizza") {
        sizeTotal = 10;
    } else if (selectedSize == "Large Pizza") {
        sizeTotal = 14;
    } else if (selectedSize == "Extra Large Pizza") {
        sizeTotal = 16;
    }

    runningTotal = sizeTotal; //this running total variable gets passed into the getTopping() function
    console.log(selectedSize+" = $"+sizeTotal+".00"); //a few console.logs, I'd argue they're just for debugging purposes
    console.log("size text1: " +text1);
    console.log("subtotal: $"+runningTotal+".00");
    getTopping(runningTotal, text1); //this is where running total and text1 go... to the next function...
}

function getTopping(runningTotal, text1) { //we have the base price, but each topping that gets selected will increase incrementally the runningTotal
    var toppingTotal = 0; //toppingTotal which will eventually get added onto runningTotal
    var selectedTopping = []; //an array that stores all the toppings the user selects
    var toppingArray = document.getElementsByClassName("toppings"); //all toppings on the html page are added to the array
    for (var j = 0; j < toppingArray.length; j++) {
        if (toppingArray[j].checked) {
            selectedTopping.push(toppingArray[j].value);
            console.log("selected topping item: ("+toppingArray[j].value+") ");
            text1 = text1+toppingArray[j].value+"<br>"; //text1 variable continues to grow... each ingredient gets added in and takes up its own line on webpage
        }
    }
    var toppingCount = selectedTopping.length; //new variable which is the quantity of toppings chosen
    if (toppingCount > 1) { //conditional statement which adds subtracts 1 (if more than more topping is chosen)... bc arrays start at 0 and we want to put this into human terms
        toppingTotal = (toppingCount - 1);
    } else {
        toppingTotal = 0;
    }
    runningTotal = (runningTotal + toppingTotal); //running total price, plus $1 per topping chosen
    console.log("total selected topping items: "+toppingCount); //4 console.logs
    console.log(toppingCount+" topping - 1 free topping = "+"$" +toppingTotal+".00");
    console.log("topping text1: " +text1);
    console.log("purchase total: "+"$"+ runningTotal + ".00");
    document.getElementById("showText").innerHTML = text1; //prints to HTML webpage
    document.getElementById("totalPrice").innerHTML= "<h3>Total: <strong>$" + runningTotal + ".00" +"</strong></h3>"; //more printing

}