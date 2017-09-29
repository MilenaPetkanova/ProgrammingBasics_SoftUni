using System;
class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("{0}{1}{0}", new string('.', 3*n/2), '*');
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', 1 + i), '*', new string('.', (3*n - 5 - 2*i)/2));
        }
        for (int i = 0; i < (n - 1)/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        Console.WriteLine("{0}", new string('*', 3*n));
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', n - 1 - i), '*', new string('.', (n - 1) / 2 + i));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', 3 * n / 2), '*');
        Console.ResetColor();
    }
}
