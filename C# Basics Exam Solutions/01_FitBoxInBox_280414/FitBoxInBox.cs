using System;
using System.Globalization;

class FitBoxInBox
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        int maxA = Math.Max(w1, Math.Max(h1, d1));
        int maxB = Math.Max(w2, Math.Max(h2, d2));

        int j;
        int i = 0;

        if (maxA > maxB)
        {
            j = w1; w1 = w2; w2 = j;
            j = h1; h1 = h2; h2 = j;
            j = d1; d1 = d2; d2 = j;
        }
        
        if (w1 < w2 && h1 < h2 && d1 < d2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, h2, d2);
            i = 1;
        }
        if (w1 < w2 && h1 < d2 && d1 < h2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, d2, h2);
            i = 1;
        }
        if (w1 < d2 && h1 < h2 && d1 < w2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, d2, h2, w2);
            i = 1;
        }
        if (w1 < d2 && h1 < w2 && d1 < h2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, d2, w2, h2);
            i = 1;
        }
        if (w1 < h2 && h1 < d2 && d1 < w2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, d2, w2);
            i = 1;
        }
        if (w1 < h2 && h1 < w2 && d1 < d2)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, w2, d2);
            i = 1;
        }
        if (i == 0)
        {
            Console.WriteLine();
        }
    }
}
