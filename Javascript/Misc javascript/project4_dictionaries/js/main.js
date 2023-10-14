function my_Dictionary() {
  var Animal = {   //declares KVPs for a dog object
    Species: "Dog",
    Color: "Black",
    Breed: "Labrador",
    Age: 5,
    Sound: "Bark!"
  }

  delete Animal.Sound; //deletes Sound aspect of dog object
  document.getElementById("Dictionary").innerHTML = Animal.Sound; //displays undefined KVP
}