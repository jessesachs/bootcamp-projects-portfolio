using System;

namespace ParsingEnums
{
    class myProgram
    {
        public enum DaysOfTheWeek //enum consisting of days of the week
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week."); //instructs users

            try //try block evaluates for catches possible errors
            {

                string userInput = Console.ReadLine(); //stores user input as string
                DaysOfTheWeek userDayInput = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput); //converts string to DaysOfTheWeek enum


            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");

            }
            finally
            {
                Console.ReadLine();
            }

        }

    }
}