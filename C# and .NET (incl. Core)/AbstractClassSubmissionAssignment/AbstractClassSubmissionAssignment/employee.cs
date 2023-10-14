using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class employee : Person //this class is a child class of person abstract class
    {
        public override void SayName() //inherited method calls back to original, abstract class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //prints first name and last name strings
        }
    }
}
