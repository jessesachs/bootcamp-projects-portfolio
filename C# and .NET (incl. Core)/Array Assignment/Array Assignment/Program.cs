using System;

class ArrayAssignment
{
    public static void Main()
    {
        var IntArray = new[] { 1, 2, 3, 4, 5 }; //declares int array
        int IntArrayLength = IntArray.Length; //declares varaiable for int array's length

        var StringArray = new[] { "One", "Two", "Three", "Four", "Five" }; //declares string array
        int StringArrayLength = StringArray.Length; //declares varaiable for string array's length

        List<string> StringList = new List<string> { "Six", "Seven", "Eight", "Nine", "Ten" }; //string list declared
        int StringListLength = StringList.Count(); //int for length of string list

        Console.WriteLine("Input an index # for Int array"); //requests user input
        int arrayIndice = Convert.ToInt32(Console.ReadLine()); //turns user input into int

        //following if statement prints user-selected index... but only if index exists in array
        if (arrayIndice > IntArrayLength)
        {
            Console.WriteLine("Invalid array indice");
        }
        else
        {
            Console.WriteLine(IntArray[arrayIndice]);
        }


        //following if statement prints user-selected index... but only if index exists array
        Console.WriteLine("Input an index # for String array");
        int stringIndice = Convert.ToInt32(Console.ReadLine());
        if (stringIndice > StringArrayLength)
        {
            Console.WriteLine("Invalid array indice");
        }
        else
        {
            Console.WriteLine(StringArray[arrayIndice]);
        }




        //following if statement prints user-selected index... but only if index exists in list
        Console.WriteLine("Input an index # for String list");
        int stringListIndice = Convert.ToInt32(Console.ReadLine());
        if (stringListIndice > StringListLength)
        {
            Console.WriteLine("Invalid list indice");
        }
        else
        {
            Console.WriteLine(StringList[stringListIndice]);
        }





        Console.ReadLine(); //end of program
    }
}
