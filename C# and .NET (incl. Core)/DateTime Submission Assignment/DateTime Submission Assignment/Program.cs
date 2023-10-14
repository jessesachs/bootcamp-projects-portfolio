using System;

namespace DateTime_Submission_Assignment
{
    class myClass
    {
        public static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now; //creates a Datetime object based on what time it is currently
            Console.WriteLine(rightNow.ToString()); //converts Datetime object to string and prints what time it is right now 
            Console.WriteLine("Input a number."); //prints user instructions
            int numHours = Convert.ToInt32(Console.ReadLine()); //int numHours is based on user input converted to integer
            DateTime HoursLater = rightNow.AddHours(numHours); //new DateTime called HoursLater is equal to rightNow (delcared above) with user input # of hours added
            Console.WriteLine(HoursLater.ToString()); //prints what time it will be in user input number of hours later

            Console.ReadLine(); //end of program


        }
    }
}