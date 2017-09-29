using System;
class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', (3*n-1)/2), new string('*', 1));

        for (int i = 0; i < (n+3)/2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', ((n*3)-2-(2*i+1))/2), '*', new string('.', 2*i+1));
        }
        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n-4-2*i), '*', new string('.', n+6+4*i));
        }
        for (int i = 0; i < (n - 1)/2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", '*', new string('.', (n-2)), '*', new string('.', n));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{4}{3}{2}{1}{0}", '*', new string('.', (2 * n - 4) / 2 - 2 * i), '*', 
                        new string('.', 2 * i - 1), '*', new string('.', n));
            }
        }
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n - 1 - i), '*', new string('.', n + 2 * i));
        }

        Console.WriteLine(new string('*', 3*n));
    }
}
