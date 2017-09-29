using System;

class House
{
    // !!!Not working

    private static void Main()
    {
        Console.WriteLine("If you want to draw a house enter how many lines you want to be the height.\nThe input should be an integer odd number,  between 5 and 49.");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("The number always should be odd.");
        }
        else if (n < 5)
        {
            Console.WriteLine("The number should be bigger than 5.");
        }
        else if (n > 49)
        {
            Console.WriteLine("The number should be smaller than 49.");
        }
        else
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', 1));
            for (int i = 1; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', ((n - 1) / 2) - i), new string('*', 1), new string('.', n * 2 - 3 - 2 * i));
            }
            Console.WriteLine("{0}", new string('*', n));
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', 1), new string('.', n * 2 - 3 - 2 * i));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('#', 1));
        }
    }
}

