using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0212.NullValueArithmetic
{
    class NullValueArithmetic
    {
        static void Main(string[] args)
        {
        }
    }
}
using System;

class NullValueArithmetic
{
    // Create a program that assigns null values to an integer and to a double variable.
    // Try to print these variables at the console. 
    // Try to add some number or the null literal to these variables and print the result.

    static void Main()
    {
        int? randomInteger = null;
        Console.WriteLine("This is the integer with Null value -> " + randomInteger);
        double? randomDouble = null;
        Console.WriteLine("This is the double with Null value -> " + randomDouble);
        
        randomInteger = 63;
        Console.WriteLine("This is the integer with value 63 -> " + randomInteger);
        randomDouble = 34243242429d;
        Console.WriteLine("This is the double with value 63 -> " + randomDouble);

        

    }
}
