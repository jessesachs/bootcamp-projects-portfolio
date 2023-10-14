using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission_Assignment
{
    public class Customer: Person, IQuittable
    {

        public override void SayName() //inherited method calls back to original, abstract class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //prints first name and last name strings
        }
        public void Quit() //quit method, inherited from IQuittable interface
        {
            Console.WriteLine("I quit being a customer!");
        }
    }
}
