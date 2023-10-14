using System;

namespace MethodAssignment2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ExtraClass mathObject = new ExtraClass(); //declares object of class ExtraClass

            //instructions for user
            Console.WriteLine("Enter two numbers, one at a time.  You do not need to input a second number.");

            //takes input to store as integer
            int input1 = Convert.ToInt32(Console.ReadLine());

            //takes input to store as string (for now)
            string rawInput = Console.ReadLine();


            if (!string.IsNullOrEmpty(rawInput)) //if the string rawInput is not null or empty, we convert it to an int
            {
                int input2 = Convert.ToInt32(rawInput);
                Console.WriteLine(mathObject.FavoriteMethod(input1, input2)); //we print the return value of mathObject.FavoriteMethod method, which adds its two parameters together
            }
            else //if the string rawInput is null or empty, we print the return value of mathObject.FavoriteMethod
            {
                Console.WriteLine(mathObject.FavoriteMethod(input1));
            }



            Console.ReadLine(); //end of program
        }
    }
}