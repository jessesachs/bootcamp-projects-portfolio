document.write(typeof 5);

var combinedstringandnumber = "my favorite number is " + 7;
document.write(combinedstringandnumber);

function myFunctions() {

    document.getElementById("equals").innerHTML = (10 == 10); //prints to html document true
    document.getElementById("equalsplus").innerHTML = (10 === "ten"); //prints false
    document.getElementById("greater").innerHTML = (10 > 5); //prints true
    document.getElementById("lesser").innerHTML = (5 < 10); //prints true
    document.getElementById("andpersand").innerHTML = ("five" && "Five"); //prints five
    document.getElementById("talllines").innerHTML = (6 || 6); //prints six
    document.getElementById("not").innerHTML = (!true); //prints false
}
