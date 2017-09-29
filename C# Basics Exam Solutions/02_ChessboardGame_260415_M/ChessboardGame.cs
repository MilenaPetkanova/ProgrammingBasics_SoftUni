using System;
class ChessboardGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        
        int blackTeam = 0;
        int whiteTeam = 0;

        for (int i = 0; i <= input.Length - 1; i += 2)   
        {
            if (i >= n * n)
            {
                break;
            }
            
            if (input[i] >= 97 && input[i] <= 122)
            {
                blackTeam += input[i];
            }
            else if (input[i] >= 65 && input[i] <= 90)
            {
                whiteTeam += input[i];
            }
            else if (input[i] >= 48 && input[i] <= 57)
            {
                blackTeam += input[i];
            }
        }
        for (int i = 1; i <= input.Length - 1; i += 2)  
        {
            if (i >= n * n)
            {
                break;
            }

            if (input[i] >= 97 && input[i] <= 122)
            {
                whiteTeam += input[i];
            }
            else if (input[i] >= 65 && input[i] <= 90)
            {
                blackTeam += input[i];
            }
            else if (input[i] >= 48 && input[i] <= 57)
            {
                whiteTeam += input[i];
            }
        }

        if (blackTeam > whiteTeam)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackTeam - whiteTeam);
        }
        else if (whiteTeam > blackTeam)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteTeam - blackTeam);
        }
        else if (blackTeam == whiteTeam)
        {
            Console.WriteLine("Equal result: {0}", blackTeam);
        }
    }
}


