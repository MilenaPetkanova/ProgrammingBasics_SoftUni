using System;
class SpyHard
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        message = message.ToLower();

        int numberOfSymbols = 0;
        int number = 0;
        int code = 0;
        int rest = 0;
        int i = 1;

        foreach (char symbol in message)
        {
            numberOfSymbols++;

            if (symbol >= 97 && symbol <= 122)
            {
                number += symbol - 96;
            }
            else
            {
                number += symbol;
            }
        }

        //number /= key;
        //rest = number % key;
        //code += rest;

        //while (number > 0)
        //{
        //    number /= key;
        //    rest = number % key;
        //    i *= 10;
        //    rest *= i;
        //    code += rest;
        //}

        string firstElement = key.ToString();
        string secondElement = numberOfSymbols.ToString();
        string thirdElement = code.ToString();
        Console.WriteLine(firstElement + secondElement + thirdElement);
    }
}
