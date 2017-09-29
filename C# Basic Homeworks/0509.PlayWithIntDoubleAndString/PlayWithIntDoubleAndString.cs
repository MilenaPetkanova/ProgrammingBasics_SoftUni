using System;

class PlayWithIntDoubleAndString
{
    // Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
    // If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. 
    // Print the result at the console. Use switch statement. 
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string\n");
        int userChoise = int.Parse(Console.ReadLine());

        switch (userChoise)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int firstCase = int.Parse(Console.ReadLine());
                Console.WriteLine(firstCase + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double secondCase = double.Parse(Console.ReadLine());
                Console.WriteLine(secondCase + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string thirdCase = Console.ReadLine();
                Console.WriteLine(thirdCase + "*");
                break;
        }
    }
}
