using System;
class DivideBy7and5
{
    // Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        bool isDivisible = n % 5 == 0 && n % 7 == 0 && n != 0 ? true : false;
        Console.WriteLine(isDivisible);
    }
}
