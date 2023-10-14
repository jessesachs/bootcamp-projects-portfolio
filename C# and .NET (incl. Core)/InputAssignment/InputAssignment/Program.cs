using System;
using System.IO; //necessary for writing, appending, reading files
using System.Linq.Expressions;

namespace InputAssignment
{
    class myProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:"); //prints to screen user instructions

            int userInput = Convert.ToInt32(Console.ReadLine()); //conversion to int ensures that user input is a number, even though we convert it back to string momentarily anyways


            File.AppendAllText(@"C:\users\jesse\desktop\repos\basic-c-sharp-projects-bootcamp\inputassignment\log.txt", userInput.ToString()); //appends file so that we can see an ever-growing list of every number that a user has ever input into the program, and writes it onto the end of a text file

            string fromFile = File.ReadAllText(@"C:\users\jesse\desktop\repos\basic-c-sharp-projects-bootcamp\inputassignment\log.txt").ToString(); //declares string variable that equals all text from the text file
            Console.WriteLine(fromFile); //prints entire text file to console


            Console.ReadLine(); //end of program
        }
    }
}