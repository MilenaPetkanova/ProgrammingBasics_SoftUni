using System;

class GravitationOnTheMoon
{
    // The gravitational field of the Moon is approximately 17% of that on the Earth.
    // Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    static void Main()
    {
        Console.WriteLine("Enter a weight of a man on the Earth: ");
        double weightOnEarth = double.Parse(Console.ReadLine());
        Console.WriteLine("The weight of this man on the Moon is " + weightOnEarth * 0.17);

    }
}
