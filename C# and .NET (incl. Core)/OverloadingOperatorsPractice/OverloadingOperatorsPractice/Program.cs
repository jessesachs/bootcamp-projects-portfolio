using System;

namespace OverloadingOperatorsPractice
{
    class myClass
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee(); //declaring employee1, first name, last name, and ID
            employee1.FirstName = "Joe";
            employee1.LastName = "Shmoe";
            employee1.Id = 1;

            Employee employee2 = new Employee(); //declaring employee2, first name, last name, and ID
            employee2.FirstName = "John";
            employee2.LastName = "Smith";
            employee2.Id = 2;

       

            Console.WriteLine(employee1 == employee2); //will return bool true
            Console.WriteLine(employee1 != employee2); //will return bool false

            Console.ReadLine(); //end of program
        }
    }
}