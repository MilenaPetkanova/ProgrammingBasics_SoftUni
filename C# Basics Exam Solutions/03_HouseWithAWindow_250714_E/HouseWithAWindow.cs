using System;
class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n - 1), '*');
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n - 2 - i), '*', new string('.', 1 + 2*i));
        }
        Console.WriteLine("{0}", new string('*', 2*n - 1));
        for (int i = 0; i < 0.25 * n; i++)
        {
            Console.WriteLine("{0}{1}{0}", '*', new string('.', 2*n - 3));
        }
        for (int i = 0; i < 0.5 * n; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", '*', new string('.', n / 2), new string('*', n - 3));
        }
        for (int i = 0; i < 0.25 * n; i++)
        {
            Console.WriteLine("{0}{1}{0}", '*', new string('.', 2 * n - 3));
        }
        Console.WriteLine("{0}", new string('*', 2*n - 1));
    }
}
