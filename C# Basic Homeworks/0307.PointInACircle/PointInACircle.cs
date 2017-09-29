using System;
class PointInACircle
{
    // Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).
    static void Main()
    {
        Console.WriteLine("Write two numbers to see if they are inside the circle K({0, 0}, 2: ");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = ((x * x) + (y * y)) <= 2 * 2;
        Console.WriteLine(isInCircle);
    }
}
