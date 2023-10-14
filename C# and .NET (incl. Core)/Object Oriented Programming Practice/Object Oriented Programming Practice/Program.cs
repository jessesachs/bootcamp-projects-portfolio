using System;

namespace Object_Oriented_Programming_Practice
{
    class OOPPMain
    {
        public static void Main(string[] args)
        {
            Class1 myObject = new Class1(); //declares new object

            Console.WriteLine("Input a number:"); //instructions for user
            int userInput = Convert.ToInt32(Console.ReadLine()); //int user input
            Console.WriteLine("Your number divided by two is...");
            myObject.outputHalf(userInput); //user input gets divided by two

            Console.WriteLine("Please input another number to perform operations on..."); //more instructions for user
            double a = Convert.ToDouble(Console.ReadLine()); //we convert user input to a double
            myObject.timesTwo(a, out double addedOne, out double addedTwo); //we call on object myObject's method timesTwo to receive output variables

            Console.WriteLine("Here are these two numbers: {0}, and {1}.", addedOne, addedTwo); //we output the output double variables from the previous statement

            Console.ReadLine(); //end of program
            
            
        }
    }
}