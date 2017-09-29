using System;
using System.Security.Cryptography.X509Certificates;

class Triangle
{
    static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double d = 0;
        double s = 0;
        double p = 0;
        double a, b, c = 0;

        d = (bX - aX)*(bX - aX) + (bY - aY)*(bY - aY);
        c = Math.Sqrt(d);
        d = (cX - aX) * (cX - aX) + (cY - aY) * (cY - aY);
        b = Math.Sqrt(d);
        d = (bX - cX) * (bX - cX) + (bY - cY) * (bY - cY);
        a = Math.Sqrt(d);

        p = (a + b + c)/2;

        d = p*(p - a)*(p - b)*(p - c);
        s = Math.Sqrt(d);

        if (s == 0)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", c);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", s);
        }
    }
}
