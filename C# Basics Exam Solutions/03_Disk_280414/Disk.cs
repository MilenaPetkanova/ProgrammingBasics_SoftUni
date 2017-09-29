using System;
class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        double mNotRounded = r / 2.0 + 0.01;
        int m = (int)Math.Round(mNotRounded);

        for (int i = 0; i < (n - 1) / 2 - r; i++)
        {
            Console.WriteLine("{0}", new string('.', n));
        }
        if (mNotRounded > 1)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 1) / 2), '*');
        }
        for (int i = 0; i < r - 1 - m; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 2 * m - 2 * i - 1) / 2), new string('*', 2 * m + 1 + 2 * i));
        }
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 2 * r + 1) / 2), new string('*', 2 * r - 1));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', (n - 2 * r - 1) / 2), new string('*', 2 * r + 1));
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 2 * r + 1) / 2), new string('*', 2 * r - 1));
        }
        for (int i = 0; i < r - 1 - m; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 2 * r + 2 * i + 3) / 2), new string('*', 2 * r -3 - 2 * i));
        }
        if (mNotRounded > 1)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 1) / 2), '*');
        }
        for (int i = 0; i < (n - 1) / 2 - r; i++)
        {
            Console.WriteLine("{0}", new string('.', n));
        }
    }
}
