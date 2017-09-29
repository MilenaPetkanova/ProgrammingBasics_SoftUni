using System;
class Illuminati
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToUpper();

        int vowelsNum = 0;
        int vowelsSum = 0;

        foreach (char letter in input)
        {
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                vowelsSum += letter;
                vowelsNum ++;
            }
        }
        Console.WriteLine(vowelsNum);
        Console.WriteLine(vowelsSum);
    }
}

