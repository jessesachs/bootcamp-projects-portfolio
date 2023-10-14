function Call_Loop() { //counts up and alerts when 10 has been reached
    var x = 5;
    while (x < 10) {
        document.getElementById("Loop").innerHTML = x;
        x++;
    }

    alert(x);

}

function for_Loop() { //for loop function, looping through instruments array
    let Instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin", "Trumpet", "Flute"];

    var Content = "";

    for (i = 0; i < Instruments.length; i++) {
        Content += Instruments[i] + "<br>";
        document.getElementById("List_Of_Instruments").innerHTML = Content;
    }
}

function array_Function() { //an array of instruments, printing text of one instrument to index document
    var Instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin", "Trumpet", "Flute"];
    document.getElementById("Array").innerHTML = Instruments[3];
}

function constant_function() { //declaring constant values
    const Musical_Instrument = {type:"guitar", brand:"Fender", color:"black"};
    Musical_Instrument.color = "blue";
    Musical_Instrument.price = 900;

    document.getElementById("Constant").innerHTML = "The cost of the " + Musical_Instrument.type + " is " + Musical_Instrument.price;
}



let car = { //object
    make: "Dodge ",
    model: "Viper ",
    year: "2021 ",
    color: "red ",
    description: function () {return "This car is a " + this.year + this.color + this.make + this.model}
};

function car_return_statement() { //function displays return statement text from car object above

    document.getElementById("Car_Object").innerHTML = car.description();
}


function Break_Statement() { //demonstrates use of break statement

    var text;
    for (let i = 0; i < 10; i++) {
        if (i === 3) { break; }
        text += "The number is " + i + "<br>";
    }

    document.getElementById("Break").innerHTML = text;
}

function Continue_Statement() { //demonstrates use of continue statement

    var text;
    for (let i = 0; i < 10; i++) {
        if (i === 3) { continue; }
        text += "The number is " + i + "<br>";
    }
    document.getElementById("Continue").innerHTML = text;
}