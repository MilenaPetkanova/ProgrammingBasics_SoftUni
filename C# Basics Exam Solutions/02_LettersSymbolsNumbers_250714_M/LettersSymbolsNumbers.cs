using System;
using System.Text.RegularExpressions;
class LettersSymbolsNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long lettersSum = 0;
        long numbersSum = 0;
        long symbolsSum = 0;

        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();

            inputLine = Regex.Replace(inputLine, @"\s", "");          
            inputLine = inputLine.ToUpper();

            foreach (char element in inputLine)
            {
                if (element >= 48 && element <= 57)
                {
                    numbersSum += (element - 48) * 20;
                }
                else if (element >= 65 && element <= 90)
                {
                    lettersSum += (element - 64) * 10;
                }
                else
                {
                    symbolsSum += 200; 
                }
            }
        }
        Console.WriteLine(lettersSum);
        Console.WriteLine(numbersSum);
        Console.WriteLine(symbolsSum);
    }
}