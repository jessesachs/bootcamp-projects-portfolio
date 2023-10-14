using Method_Practice_3;
using System;

namespace MethodPractice3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Class1 myClass = new Class1(); //instantiates new object

            myClass.funMethod(firstInt: 7, secondInt: 3); //calls on method 'funMethod', names and passes in two integers

            Console.ReadLine(); //end of program
        }
    }
}