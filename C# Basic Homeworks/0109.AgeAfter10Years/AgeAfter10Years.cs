using System;
class PrintAgeAfter10Years
{
    // Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
    static void Main()
    {
        Console.Write("Write down your Birthday YYYY-MM-DD: ");

        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        Console.WriteLine("Your age now: " + (today.Year - birthDate.Year));
        Console.WriteLine("Your age after 10 years: " + (today.Year - birthDate.Year + 10));
    }
}

// Should print my age