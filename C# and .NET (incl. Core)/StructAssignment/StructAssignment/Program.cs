using System;

namespace StructAssignment
{
    class myClass
    {
        public static void Main(string[] args)
        {
            Number num1 = new Number(); //declares object of Number struct called num1
            num1.amount = 7; //assigns a value to num1's decimal variable, 'amount'
            Console.WriteLine(num1.amount); //prints struct's 'amount' decimal value
            Console.ReadLine(); //closes out program
        }
    }
}
