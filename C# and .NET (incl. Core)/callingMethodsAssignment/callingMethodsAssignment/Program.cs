using callingMethodsAssignment;
using System;


namespace callingMethodsAssignment
{
    class callingMethodsAssignment
    {
        public static void Main(string[] args)
        {
            //declares object Mathmatician
            mathExpert Mathmatician = new mathExpert();

            //asks and takes user input
            Console.WriteLine("Input a number for the mathmatician to perform some math with...");
            int userInput = Convert.ToInt32(Console.ReadLine());


            //calls on methods in object, stores return values as int variables
            int addedNumber = Mathmatician.addSomething(userInput);
            int subtractedNumber = Mathmatician.subtractSomething(userInput);
            int multipliedNumber = Mathmatician.multiplySomething(userInput);


        //following prints all returned variables
            Console.WriteLine(addedNumber);
            Console.WriteLine(subtractedNumber);
            Console.WriteLine(multipliedNumber);

        //end of program
            Console.ReadLine();

        }

    }
}