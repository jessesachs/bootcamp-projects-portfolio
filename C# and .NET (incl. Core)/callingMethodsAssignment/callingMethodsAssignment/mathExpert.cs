using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethodsAssignment
{
    //declares a class
    public class mathExpert
    {
        //first method takes user input passed in from main class, then adds 1 to it and returns the int
        public int addSomething(int userInput)
        {
            userInput++;

            return userInput;
        }

        //second method subtracts one from user input and returns int
        public int subtractSomething(int userInput)
        {
            userInput--;

            return userInput;
        }

        //third method of class multiplies user input by two and returns int
        public int multiplySomething(int userInput)
        {
            userInput *= 2;
            return userInput;
        }

    }


}
