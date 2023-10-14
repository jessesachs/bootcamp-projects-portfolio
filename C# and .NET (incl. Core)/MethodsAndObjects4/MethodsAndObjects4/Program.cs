using System;

namespace MethodsAndObjects4
{
    public class letsGo
    {
        public static void Main(string[] args)
        {
            person Person1 = new person(); //declares a person object

            employee Employee1 = new employee(); //declares an employee object, which is a child class of superclass person
            Employee1.firstName = "Sample"; //employee's first name gets declared
            Employee1.lastName = "Student"; //and last name
            Employee1.SayName(); //person object's method that prints name gets called on child class student



            Console.ReadLine(); //end of program
        }
    }
}