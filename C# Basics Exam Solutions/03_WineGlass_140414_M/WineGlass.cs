using System;
class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 1)
        {
            Console.WriteLine("The number always should be even.");
            return;
        }
        if (n < 4)
        {
            Console.WriteLine("The number should be bigger than 4.");
            return;
        }
        if (n > 60)
        {
            Console.WriteLine("The number should be smaller than 60.");
            return;
        }

        Console.WriteLine("{0}{1}{2}", new string('\\', 1), new string('*', n - 2), new string('/', 1));

        for (int i = 1; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', i), new string('\\', 1), new string('*', n - 2 - 2 * i), new string('/', 1));
        }

        Console.WriteLine("{0}{1}{2}{0}", new string('.', n / 2 - 1), new string('\\', 1), new string('/', 1));

        if (n < 12)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n / 2 - 1), new string('|', 2));
            }
            Console.WriteLine("{0}", new string('-', n));
        }
        else
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n / 2 - 1), new string('|', 2));
            }
            Console.WriteLine("{0}", new string('-', n));
            Console.WriteLine("{0}", new string('-', n));
        }
    }
}
