using System;
class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char letterOne = ' ';
        char letterTwo = ' ';

        byte j = 65;
        int a;

        for (int i = 0; i < (n - 1)/2; i++)
        {
            a = (j - 65)%26 + 65;
            letterOne = (char)a;
            j += 1;
            a = (j - 65) % 26 + 65;
            letterTwo = (char)a;
            j += 1;

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', i), letterOne, new string('#', n-2*i-2), letterTwo);
        }

        a = (j - 65) % 26 + 65;
        letterOne = (char)a;
        Console.WriteLine("{0}{1}{0}", new string('-', (n-1)/2), letterOne);
        j += 1;

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            a = (j - 65) % 26 + 65;
            letterOne = (char)a;
            j += 1;
            a = (j - 65) % 26 + 65;
            letterTwo = (char)a;
            j += 1;

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', (n-3)/2 - i), letterOne, new string('#', 2*i + 1), letterTwo);
        }
    }
}
