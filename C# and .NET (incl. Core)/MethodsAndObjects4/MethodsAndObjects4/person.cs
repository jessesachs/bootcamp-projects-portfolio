using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects4
{
    public class person
    {
        public string firstName; //first name is a property of a person object
        public string lastName; //and so is last name

        public void SayName() //this method prints to screen a person object's full name
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
