using System;
class tryandcatch
{
    public static void Main(string[] args)
    {

        var intList = new List<int>() {1, 7, 3, 9, 8, 3 } ; //list of integers
        Console.WriteLine("Please input a number to divide each number in the list by."); //tells user what to do
        
        try //beginning of try block
        {
            int userInput = Convert.ToInt32(Console.ReadLine()); //converts user input to integer
            for (int i = 0; i < intList.Count; i++) //divides each number in intList by user input
            {
                int dividedNumber = intList[i] / userInput; //int variable stored as mathmatical product of intList divided by userInput
                Console.WriteLine(dividedNumber); //prints the divided number to the screen
            }
        }
        catch (DivideByZeroException ex) //error catch block for dividing by zero
        {
            Console.WriteLine(ex.Message); //displays divide by zero error message
        }
        catch (FormatException ex) //error catch block for when string is inputted by user
        {
            Console.WriteLine(ex.Message); //displays format exception error message
        }
        finally //program continues onto here
        {
            Console.WriteLine("We have emerged from the catch blocks and now the program may continue to run"); //tells user what happened
            Console.ReadLine(); //end of program if error occurs
        }

        Console.ReadLine(); //end of program if program runs successfully

    }

}