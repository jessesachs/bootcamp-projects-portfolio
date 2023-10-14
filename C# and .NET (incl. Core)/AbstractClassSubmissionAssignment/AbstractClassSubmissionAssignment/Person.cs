using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person //abstract superclass
    {
        //object properties declared below
        public string firstName;
        public string lastName;

        public abstract void SayName(); //abstract class method
    }
}
