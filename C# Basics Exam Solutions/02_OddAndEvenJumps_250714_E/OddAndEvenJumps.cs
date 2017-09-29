using System;
class OddAndEvenJumps
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        ushort oddJump = ushort.Parse(Console.ReadLine());
        ushort evenJump = ushort.Parse(Console.ReadLine());
        
        inputLine = inputLine.ToLower().Replace(" ", "");
        
        ulong oddResult = 0;
        ulong evenResult = 0;
        int oddCounter = 0;
        int evenCounter = 0;
     
        bool oddLetter = true;
        for (int i = 0; i < inputLine.Length; i++)
        {
            if (oddLetter)
            {
                oddCounter++; // to start from 1, not from 0
                if (oddCounter % oddJump == 0)
                {
                    oddResult *= inputLine[i];
                }
                else
                {
                    oddResult += inputLine[i];
                }
            }
            else
            {
                evenCounter++;
                if (evenCounter % evenJump == 0)
                {
                    evenResult *= inputLine[i];
                }
                else
                {
                    evenResult += inputLine[i];
                }
            }
            oddLetter = !oddLetter;
        }

        string oddSumInHex = oddResult.ToString("X");
        string evenSumInHex = evenResult.ToString("X"); 

        Console.WriteLine("Odd: " + oddSumInHex);
        Console.WriteLine("Even: " + evenSumInHex);
    }
}
