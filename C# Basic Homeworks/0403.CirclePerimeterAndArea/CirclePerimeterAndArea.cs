using System;

class CirclePerimeterAndArea
{
    // Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 
    static void Main()
    {
        Console.WriteLine("Enter radius of a circle: ");
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = pi * 2 * r;
        double area = pi * r * r;
        Console.WriteLine("The perimeter of this circle is: {0:F2}\nIts area is: {1:F2}", perimeter, area);

    }
}
