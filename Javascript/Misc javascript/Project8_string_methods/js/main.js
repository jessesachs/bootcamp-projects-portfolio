function full_Sentence() { //this function produces a full sentence with concatenation
    var part_1 = "I have ";
    var part_2 = "made this ";
    var part_3 = "into a complete ";
    var part_4 = "sentence.";
    var whole_sentence = part_1.concat(part_2, part_3, part_4);
    document.getElementById("Concatenate").innerHTML = whole_sentence;
}

function slice_Method() { //this function uses the slice method to produce the string "johnny"
    var Sentence = "All work and no play makes Johnny a dull boy.";
    var Section = Sentence.slice(27, 33);
    document.getElementById("slice").innerHTML = Section;

    makeItString(); //this calls the next function (see right below)
}

function makeItString() { //this turns an int variable into a string

    let mynumber = 5;
    let myString = mynumber.toString();
    document.getElementById("displaystring").innerHTML = myString;
}

function precision_Method() { //this function declares a variable and uses the precision method to 'clip' that variable
    var X = 12938.3012987376112;
    document.getElementById("Precision").innerHTML = X.toPrecision(10);
}