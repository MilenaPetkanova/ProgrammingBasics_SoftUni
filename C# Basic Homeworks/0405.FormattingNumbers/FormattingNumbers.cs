using System;
class FormattingNumbers
{
    // Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them 
    // in 4 virtual columns on the console. Each column should have a width of 10 characters. 
    // The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, 
    // then the number b should be printed with 2 digits after the decimal point, right aligned; 
    // the number c should be printed with 3 digits after the decimal point, left aligned. 
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers: /an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c/");
        string a = Console.ReadLine();
        int numberA = int.Parse(a);
        string b = Console.ReadLine();
        float numberB = float.Parse(b);
        string c = Console.ReadLine();
        float numberC = float.Parse(c);

        if (numberA < 0)
        {
            Console.WriteLine("The first number should be (0 ≤ a ≤ 500). Try again.");
            return;
        }
        else if (numberA > 500)
        {
            Console.WriteLine("The first number should be (0 ≤ a ≤ 500). Try again.");
            return;
        }
        else
        {
            string hexValueA = numberA.ToString("X");
            string binaryValueA = Convert.ToString(numberA, 2).PadLeft(10, '0');

            numberB.ToString("G29");
            numberC.ToString("G29");

            Console.WriteLine("{0,-10}|{1,10}|{2,10:F2}|{3,-10:F3}", hexValueA, binaryValueA, numberB, numberC);
        }


    }
}

