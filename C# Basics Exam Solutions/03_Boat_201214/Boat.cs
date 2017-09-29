using System;
class Boat
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
        if (n > 39)
        {
            Console.WriteLine("The number should be smaller than 39.");
            return;
        }
        
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', n - 1 - 2*i), new string('*', 1 + 2*i), new string('.', n));
        }
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', 2 + 2*i), new string('*', n - 2 - 2*i), new string('.', n));
        }
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', 2*n - 2*i));
        }
    }
}
