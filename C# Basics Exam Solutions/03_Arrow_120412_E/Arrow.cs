using System;
class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("The number always should be odd.");
        }
        else if (n < 3)
        {
            Console.WriteLine("The number should be bigger than 3.");
        }
        else if (n > 79)
        {
            Console.WriteLine("The number should be smaller than 79.");
        }
        else
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 1) / 2), new string('#', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n - 1) / 2), new string('#', 1), new string('.', n - 2));
            }
            Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n - 2));
            for (int i = 1; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', 1), new string('.', n * 2 - 3 - 2 * i));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('#', 1));
        }
    }
}

