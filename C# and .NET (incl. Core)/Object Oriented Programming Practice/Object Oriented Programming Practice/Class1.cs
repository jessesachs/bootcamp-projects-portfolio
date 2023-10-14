using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Practice
{
    public class Class1
    {
        public void outputHalf (int input1) //method divides by half
        {
            Console.WriteLine(input1 / 2);
        }

        public void timesTwo(int input2, out int addedOne, out int subtractedOne) //method takes one input and passes out two parameters
        {
            addedOne = input2++; //one of the out parameters is an increment of the input
            subtractedOne = input2--; //the other is a decremement of the input
        }
        public void timesTwo(double input2, out double addedOne, out double subtractedOne) //this method is the same as the one before, but its for doubles, not ints
        {
            addedOne = input2 + 1.0f;
            subtractedOne = input2 - 1.0f;
        }

    }

}
