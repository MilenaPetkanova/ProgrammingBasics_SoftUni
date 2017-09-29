using System;

class StringsAndObjects
{
    // Declare two string variables and assign them with “Hello” and “World”. 
    //Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). 
    //Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

    static void Main()
    {
        string alpha = "Hello";
        string beta = "World";

        object myFirstObject = alpha + ", " + beta + "!";
        string gamma = (string)myFirstObject;

        Console.WriteLine(myFirstObject);
        Console.WriteLine(gamma);
    }
}

