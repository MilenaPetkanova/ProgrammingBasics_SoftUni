using System;
class PointCircleAndRectangle
{
    // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
    // and out of the rectangle R(top=1, left=-1, width=6, height=2). 
    static void Main()
    {
        Console.WriteLine("Enter a point (x, y)");
        double x = Double.Parse(Console.ReadLine());
        double y = Double.Parse(Console.ReadLine());
        bool isInCircle = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5 * 1.5);
        bool isInRectangle = (x >= 5 && x <= -1) && (y >= -1 && y <= 1);
        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {

            Console.WriteLine("no");
        }
    }
}
