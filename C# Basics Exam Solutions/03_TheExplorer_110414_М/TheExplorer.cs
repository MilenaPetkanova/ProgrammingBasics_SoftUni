﻿using System;
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("The number always should be odd.");
            return;
        }
        if (n < 3)
        {
            Console.WriteLine("The number should be bigger than 3.");
            return;
        }
        if (n > 59)
        {
            Console.WriteLine("The number should be smaller than 59.");
            return;
        }

        Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), '*');
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', n / 2 - i - 1), '*', new string('-', 1 + 2 * i));
        }
        for (int i = 1; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', i), '*', new string('-', n - i * 2 - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), '*');
    }
}
