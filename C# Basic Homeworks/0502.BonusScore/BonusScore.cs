using System;
using System.Runtime.ExceptionServices;

class BonusScore
{
    // Write a program that applies bonus score to given score in the range [1…9] by the following rules:
    //•	If the score is between 1 and 3, the program multiplies it by 10.
    //•	If the score is between 4 and 6, the program multiplies it by 100.
    //•	If the score is between 7 and 9, the program multiplies it by 1000.
    //•	If the score is 0 or more than 9, the program prints “invalid score”.
    static void Main()
    {
        Console.WriteLine("Enter a score in the range [1…9]:");
        int score = int.Parse(Console.ReadLine());
        if (score <= 3 && score >= 1)
        {
            int firstCase = score * 10;
            Console.WriteLine("Bonus score: {0}", firstCase);
        }
        else if (score <= 6 && score >= 4)
        {
            int secondCase = score * 100;
            Console.WriteLine("Bonus score: {0}", secondCase);
        }
        else if (score <= 9 && score >= 7)
        {
            int thirdCase = score * 1000;
            Console.WriteLine("Bonus score: {0}", thirdCase);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}

