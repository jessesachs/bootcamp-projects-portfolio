function Vehicle(Make, Model, Year, Color) //constructor/class for cars
{
    this.Vehicle_Make = Make;
    this.Vehicle_Model = Model;
    this.Vehicle_Year = Year;
    this.Vehicle_Color = Color;
}

//declares new objects: Jack, Emily, Erik
var Jack = new Vehicle("Dodge", "Viper", 2020, "Red");
var Emily = new Vehicle("Jeep", "Trail Hawk", 2019, "White and Black");
var Erik = new Vehicle("Ford", "Pinto", 1971, "Mustard");

function myFunction() { //uses ternary operator to show who has older car
    document.getElementById("Keywords_and_Constructors").innerHTML = "Erik drives a " + Erik.Vehicle_Color + "-colored " + Erik.Vehicle_Model + " manufactured in " + Erik.Vehicle_Year;
    var olderCar = (Erik.Vehicle_Year > Emily.Vehicle_Year ? "Emily has the older car" : "Erik has the older car" );
    document.getElementById("whohasoldercar").innerHTML = olderCar;
}

function count_Function() { //outer and innner/nested function that counts from 9 to 10 
    document.getElementById("Counting").innerHTML = Count();
    function Count() {
        var Starting_point = 9;
        function Plus_one() {Starting_point +=1;}
        Plus_one();
        return Starting_point;
    }
}
