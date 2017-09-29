using System;
class PrimeNumberCheck
{
    // Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
    // (i.e. it is divisible without remainder only to itself and 1). 
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (n > 1)
        {
            if (n < 100)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        Console.WriteLine(isPrime);
                        Console.WriteLine("The number is not prime.");
                        return;
                    }
                }
                Console.WriteLine(isPrime);
                Console.WriteLine("This number is prime.");
            }
            else
            {
                Console.WriteLine("Invalid input. The number should be ≤ 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. The number should be positive.");
        }
    }
}



