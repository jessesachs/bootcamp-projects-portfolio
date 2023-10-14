using System;

namespace ConstructorSubmission
{
    class myProgram
    {
        public static void Main(string[] args)
        {
            const string myName = "Jesse"; //constant string username declared here

            var message = new List<string>() {"Hi", "Yo", "What's up?"}; //var list with three greetings

            Random random = new Random(); //random number generator
            int x = random.Next(0, 2); //random number between 0 and 2 (size of above list) generated

            class1 myObject = new class1(myName, message[x].ToString()); //first instance of object, constructor takes myName (const string from above) and passes in a random string message between 0 and 2

            class1 myOtherObject = new class1(myName); //creates a second object, this time without a random message

            Console.ReadLine(); //end of program
        }
    }
}