using System;
class EmployeeData
{
    //A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    //•	First name
    //•	Last name
    //•	Age (0...100)
    //•	Gender (m or f)
    //•	Personal ID number (e.g. 8306112507)
    //•	ccccccccccccccccccc (27560000…27569999)
    //Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
    //Use descriptive names. Print the data at the console.

    static void Main()
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        byte age = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter gender: (m/f)");
        char gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter Personal ID number: ");
        int idNumber = (int)Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter Unique employee number: ");
        long uniqueNumber = (long)Convert.ToUInt64(Console.ReadLine());

        Console.WriteLine("\n");
        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique employee number: {5}\n", firstName, lastName, age, gender, idNumber, uniqueNumber);

    }
}
