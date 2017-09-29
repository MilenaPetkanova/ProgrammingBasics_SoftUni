using System;
using System.Globalization;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char m = char.Parse(Console.ReadLine());

        int[] letterCount = new int[] { 1, 3, 5, 7, 5, 3, 1 };
        char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        char[] currentRow = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

        int e = 7;

        for (int d = 0; d < 7; d++)
        {
            if (letters[d] == m)
            {
                e = d;
            }
        }
        for (int i = 0; i < n; i++)
        {
            int j = letterCount[i%7];

            for (int a = 0; a < (7 - j)/2; a++)
            {
                currentRow[a] = '.';
                currentRow[6 - a] = '.';
            }
            for (int c = 0; c < j; c++)
            {
                currentRow[(7 - j)/2 + c] = letters[e%7];
                e += 1;
            }
            for (int b = 0; b < currentRow.Length; b++)
            {
                Console.Write(currentRow[b]);
            }
            Console.WriteLine();
        }
    }
}
