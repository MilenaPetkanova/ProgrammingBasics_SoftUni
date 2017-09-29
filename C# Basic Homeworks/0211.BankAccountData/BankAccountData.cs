using System;

class BankAccountData
{
    // A bank account has a holder name (first name, middle name and last name), 
    // available amount of money (balance), 
    // bank name, IBAN, 3 credit card numbers associated with the account. 
    // Declare the variables needed to keep the information for a single bank account 
    // using the appropriate data types and descriptive names.
    static void Main()
    {
        Console.WriteLine("Enter first name account:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter middle name account:");
        string middleName = Console.ReadLine();
        Console.WriteLine("Enter last name account:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter available amount of money:");
        long balance = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter bank name:");
        string bankName = Console.ReadLine();
        Console.WriteLine("Enter IBAN:");
        string iban = Console.ReadLine();
        Console.WriteLine("Enter number of first credit card account:");
        int firstCreditCard = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of second credit card account:");
        int secondCreditCard = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of third credit card account:");
        int thirdCreditCard = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");
        Console.WriteLine("First name: {0}\nMiddle name: {1}\nLast name: {2}\nAvailable amount of money: {3}\n" +
                          "Bank name: {4}\nIBAN: {5}\nCredit card 1: {6} {0} {2}\nCredit card 2: {7} {0} {2}\nCredit card 3: {8} {0} {2}\n",
                          firstName, middleName, lastName, balance, bankName, iban, firstCreditCard, secondCreditCard, thirdCreditCard);

    }
}


