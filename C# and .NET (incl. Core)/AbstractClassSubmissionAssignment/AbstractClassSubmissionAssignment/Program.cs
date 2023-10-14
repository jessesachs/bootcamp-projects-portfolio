using System;

namespace AbstractClassSubmissionAssignment
{
    class myProgram
    {
        public static void Main(string[] args)
        {
            employee employee1 = new employee(); //instantiates an 'employee' object, which is a child class of abstract superclass 'Person'
            employee1.firstName = "Sample"; //sets object's first name string variable
            employee1.lastName = "Student"; //sets object's last name string variable

            employee1.SayName(); //calls on SayName method of employee class, as inherited by person class
            Console.ReadLine(); //end of program

        }
    }
}