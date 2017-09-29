using System;
class CheatSheet
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        long verticalNumber = long.Parse(Console.ReadLine());
        long horizontalNumber = long.Parse(Console.ReadLine());

        for (long i = verticalNumber; i < verticalNumber + rows; i++)
        {
            for (long j = horizontalNumber; j < horizontalNumber + columns; j++)
            {
                Console.Write(i*j);
                if (j < horizontalNumber + columns - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
