using System;
class myConsAppPart1
{
    static void Main()
    {
        string[] strArray1 = { "Dinosaur", "Raccoon", "Bee", "Squirrel", "Shark" }; //declares string array

        Console.WriteLine("Please input text below:"); //asks user to input text
        int arrayLength = strArray1.Length; //stores int value of length of array
        string userInput = Console.ReadLine(); //stores user input as string

        for (int i = 0;  i < arrayLength; i++) //for loop concatenates each item in string array with userInput variable
        {
            strArray1[i] = string.Concat(strArray1[i], userInput);
        }

        for (int i = 0; i < arrayLength; i++) //prints each item in strArray array one at a time
        {
            Console.WriteLine(strArray1[i]);
        }


        for (int i = 1; i < 5; i++) //originally an infinite loop until I changed the parameter 'i > 0' to 'i < 5'
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 5; i++) //loop with less-than operator
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i <= 4; i++) //loop with less-than-or-equal-to operator
        {
            Console.WriteLine(i);
        }


        //in this block of code, we declare a list of strings, ask the user to guess a word, and then store the user's guess as its own variable

        var stringList1 = new List<string>() {"hi", "my", "name", "is", "the", "real", "slim", "shady" };
        Console.WriteLine("Input text again to see if its in the string list");
        string userInput2 = Console.ReadLine().ToLower();

        bool onList = false; //we declare a boolean that, by default, is false.  If the user input is on the list, this onList boolean variable turns true.

        int indice = 0;

        foreach (string i in stringList1) //looping through the string list
        {
            if (userInput2 == i)
            {
                onList = true; //if user input matches one of the string list items, the boolean onList becomes true
                break; //break exits the foreach loop once we match user input with a list item
            }

            indice++;
        }

        if (onList == true) //if onList is true, the text below gets printed
        {
            Console.WriteLine("The indice " + indice + " has text matching the user input.");
        }
        else //if onList is false, the text below gets printed
        {
            Console.WriteLine(userInput2 + " is not on the list");
        }




        var stringList2 = new List<string>() { "hi", "my", "name", "name", "is", "the", "the", "real", "slim", "shady" }; //new string list declared with a few duplicate entries
        Console.WriteLine("Input text to see if its in the string list"); //prints instructions to user
        string userInput3 = Console.ReadLine().ToLower(); //stores user input as lower-case string


        int numberOfMatches = 0; //keeps a count of the number of matches between user-inputted text and stringList2 list items
        for (int i = 0; i < stringList2.Count; i++) //loops through whole list
        {
            if (stringList2[i] == userInput3) //if list item is equivalent of userInput3 then it prints that indice to the screen and numberOfMatches increases by one
            {
                Console.WriteLine("Index #" + i + " of string list matches user input");
                numberOfMatches++;
            }
            if (numberOfMatches == 0 && i == stringList2.Count - 1) //this if-statement tells user if their input ndoesn't match the list
            {
                Console.WriteLine("Sorry, the text you input does not match any of the strings on the list");
            }
        }


        var stringList3 = new List<string>() {"A", "B", "C", "B", "D", "E" }; //declares a list of strings with one duplicate entry ("B")

        //the following for loop (and within it, another nested for loop) looks for duplicates items within string list declared above

        var dupList = new List<string>() { };
        // empty list which will be used below

        foreach (string item in stringList3) //this foreach loop loops through all stringList3 items and adds them to dupList list, making note when/where duplicates occur
        {
            if (dupList.Contains(item))
            {
                Console.WriteLine(item + " is a duplicate.");
            }
            else
            {
                dupList.Add(item);
                Console.WriteLine(item + " is NOT a duplicate");
            }
        }


        Console.ReadLine(); //end of program
    }
}