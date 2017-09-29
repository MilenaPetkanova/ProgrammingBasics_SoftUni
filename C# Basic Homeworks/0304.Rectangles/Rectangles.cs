using System;
class Rectangles
{
    // Write an expression that calculates rectangle’s perimeter and area by given width and height.
    static void Main()
    {
        Console.WriteLine("Write a rectangle's weight and height: ");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The rectangle’s perimeter and area are {0} and {1}", (width + height) * 2, width * height);
    }
}
