using System;
class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        int c = v + x + 3 * y;
        int index = x + 1 + 3*y;
        long result = (long) Math.Pow(c, index);
        Console.WriteLine(result);
    }
}
