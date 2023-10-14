using System;
using System.Reflection.Metadata;

class shippingQuote
{
    static void Main()
    {
        Console.WriteLine("Hello! Welcome to Package Express.Please follow the instructions below");
        Console.WriteLine("Enter package weight.");
        int packageWeight = Convert.ToInt32(Console.ReadLine()); //stores package weight as int variable from user input

        if (packageWeight <= 50)
        { //if package weight is under or equal to 50, the following if-statement branch gets executed

            Console.WriteLine("Please enter package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());  //stores package width as int variable from user input
            Console.WriteLine("Please enter package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());  //stores package height as int variable from user input
            Console.WriteLine("Please enter package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());  //stores package length as int variable from user input

            int dimensionsTotal = packageWidth + packageHeight + packageLength; //stores int that is the sum of the weidth, height, and length variables

            if (dimensionsTotal > 50) //nested if-statement disqualifies packages that are over 50 in dimensionsTotal variable
            {
                Console.WriteLine("Package too big to be shipped via Package Express."); //if package is disqualified, system prints this
            }
            else //if dimensionsTotal variable is under or equal to 50, the following nested branch gets executed
            {
                double packageQuote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100; //double variable packageQuote determined via formula
                Console.WriteLine("Your estimated total for shipping this package is: $" + packageQuote); //prints packageQuote
                Console.WriteLine("Thank you!");
            }
        }
        else //if package weight is over 50, the following gets printed to screen
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }

        Console.Read(); //end of program

    }
}


