using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose: [r]ock, [p]aper, [s]cissors");
        
        char key;
        
        while (true)
        {
            key = Console.ReadKey(true).KeyChar;  
            
            if (key == 'r' || key == 'p' || key == 's')
            {
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice! Try again: [r]ock, [p]aper, [s]cissors");
            }
        }
        
        switch (key)
        {
            case 'r':
                Console.WriteLine("\nYou chose Rock!");
                break;
            case 'p':
                Console.WriteLine("\nYou chose Paper!");
                break;
            case 's':
                Console.WriteLine("\nYou chose Scissors!");
                break;
        }

        Random random = new Random();
       string[] moves = { "Rock", "Paper", "Scissors"};
       string computerMoves = moves[random.Next(0, 3)];
       Console.WriteLine($"The computer chose {computerMoves}!");

       if (computerMoves == "Rock" && key == 'p' || computerMoves == "Paper" && key == 's' ||
           computerMoves == "Scissors" && key == 'r')
       {
           Console.WriteLine("You win!");
       }
       else if ( key == 'r' && computerMoves == "Paper" || key == 's' && computerMoves == "Rock" || key == 'p' && computerMoves == "Scissors")
           {
           Console.WriteLine("You lose!");
           }
       else
       {
           Console.WriteLine("Draw");
       }
       
    }
}