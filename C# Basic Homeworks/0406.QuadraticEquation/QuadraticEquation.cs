using System;
class QuadraticEquation
{
    // Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 
    static void Main()
    {

        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());
        double determinant = (coefB * coefB) - (4 * coefA * coefC);

        if (determinant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (determinant > 0)
        {
            Console.WriteLine("x1={0}", (-coefB - Math.Sqrt(determinant)) / (2 * coefA));
            Console.WriteLine("x2={0}", (-coefB + Math.Sqrt(determinant)) / (2 * coefA));
        }
        else
        {
            Console.WriteLine("x1=x2={0}", (-coefB / (2 * coefA)));
        }

    }
}
