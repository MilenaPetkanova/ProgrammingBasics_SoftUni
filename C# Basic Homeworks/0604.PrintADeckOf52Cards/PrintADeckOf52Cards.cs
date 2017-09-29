using System;

class PrintADeckOf52Cards
{
    // Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
    // The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
    // Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
    static void Main()
    {
        char[] suitsCharArray = { '\u2663', '\u2666', '\u2665', '\u2660' };

        for (int i = 2; i < 10; i++)
        {
            for (int ch = 0; ch < suitsCharArray.Length; ch++)
            {
                Console.Write(i + "" + suitsCharArray[ch] + " ");
            }
        Console.WriteLine();
        }

        for (int i = 10; i <= 14; i++)
        {
            switch (i)
            {
                case 11:
                    for (int k = 0; k <= 3; k++)
                    {
                        Console.Write("J" + suitsCharArray[k] + " ");
                    } 
                    break;
                case 12:
                    for (int j = 0; j <= 3; j++)
                    {
                        Console.Write("Q" + suitsCharArray[j] + " ");
                    } 
                    break;
                case 13:
                    for (int q = 0; q <= 3; q++)
                    {
                        Console.Write("K" + suitsCharArray[q] + " ");
                    } 
                    break;
                case 14:
                    for (int a = 0; a <= 3; a++)
                    {
                        Console.Write("A" + suitsCharArray[a] + " ");
                    } 
                    break;
                default:
                    Console.WriteLine("Not possible");
                    break;
                }
            Console.WriteLine();
            }
        }
    }
}
