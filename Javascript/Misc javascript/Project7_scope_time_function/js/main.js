var GlobalVariable = 7; //local variable assignment requirement

function theHoursFunction() { //asks how ones day is if its daytime (before 6 pm)

    if (new Date().getHours() < 18) {
        document.getElementById("statement").innerHTML = "How are you today?";
    }
}

function Age_Function() { //determines whether one is old enough to vote or not
    Age = document.getElementById("Age").value;

    if (Age >= 18) {
        Vote = "You are old enough to vote!";
    }

    else {
        Vote = "You are not old enough to vote!";
    }

    document.getElementById("How_old_are_you").innerHTML = Vote;
}

function Time_function() { //tells what time of the day it is using if/elseif/else statements
    var Time = new Date().getHours(); //local variable assignment requirement
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It is morning time!";
    }
    else if (Time >= 12 == Time < 18) {
        Reply = "It is afternoon.";
    }
    else {
        Reply = "It is evening time.";
    }
    document.getElementById("Time_of_day").innerHTML = Reply;
}

function Has_Error() { //a function with an error
    firstNumber = 5;
    console.log(firsNumber);
}