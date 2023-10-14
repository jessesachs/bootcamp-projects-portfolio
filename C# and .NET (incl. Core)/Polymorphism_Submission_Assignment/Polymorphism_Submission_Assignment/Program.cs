using System;

namespace Polymorphism_Submission_Assignment
{
    class myProgram
    {
        public static void Main(string[] args)
        {
            IQuittable employee1 = new employee(); //instantiates object of employee, type of person
            employee1.Quit(); //employee quits

            IQuittable customer1 = new Customer(); //instatiates object of customer, type of person
            customer1.Quit(); //customer quits

            Console.ReadLine(); //end of program
        }
    }
}