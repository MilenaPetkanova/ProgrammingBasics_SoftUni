using System;
using System.Runtime.InteropServices;

class FourDigitNumber
{
    // Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    // •	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    // •	Prints on the console the number in reversed order: dcba (in our example 1102).
    // •	Puts the last digit in the first position: dabc (in our example 1201).
    // •	Exchanges the second and the third digits: acbd (in our example 2101).
    // The number has always exactly 4 digits and cannot start with 0.
    static void Main()
    {
        Console.WriteLine("Write a four-digit number: ");
        int n = int.Parse(Console.ReadLine());
        int d = n % 10;
        int c = (n / 10) % 10;
        int b = (n / 100) % 10;
        int a = (n / 1000) % 10;
        if (a == 0)
        {
            Console.WriteLine(false);
            return;
        }     

        int sum = a + b + c + d;
        Console.WriteLine("Sum of digits: {0}", sum);
        Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
    
    }
}

    static void Main()
    {
        Console.WriteLine("Write a four-digit number: ");
        int n = int.Parse(Console.ReadLine());

        int d = n%10;
        int c = (n/10)%10;
        int b = (n/100)%10;
        int a = (n/1000)%10;
        if (a == 0)
        {
            Console.WriteLine(false);
            return;
        }     
        int sum = a + b + c + d;
        int reversedOrder = d*1000 + c*100 + b*10 + a;
        int lastDigit = d*1000 + a*100 + b*10 + c;
        int exchange = a*1000 + c*100 + b*10 + d;
        
        Console.WriteLine("\nThe sum of the digits is: {0}\nThe number in reveesed order is: {1}" +
                          "\nThe last digit in first position: {2}\nExchanged the second and the third digits: {3}"
                          , sum, reversedOrder, lastDigit, exchange);
        
    }