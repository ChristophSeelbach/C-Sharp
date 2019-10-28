using System;

namespace ConnectGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Please enter number of cols: ");
                int cols = int.Parse(Console.ReadLine());

                var game = new ConnectGame(rows, cols);
                game.DrawBoard();

                while (game.IsRunning)
                {
                    try
                    {
                        Console.Write($"Player '{game.ActivePlayer}': ");
                        var input = Console.ReadLine();
                        Move m = ConnectGame.ParseMove(input);

                        game.AddMove(m);
                        game.DrawBoard();
                    }
                    catch (InvalidMoveException)
                    {
                        Console.WriteLine("\t - Input is not a valid move!");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\t - Input is not a valid move command!");
                    }
                }

                Console.WriteLine($"Player '{game.Winner}' won the game!");

                Console.WriteLine("Do you want to play again? (y/n)");
                var answer = Console.ReadLine();
                if (answer.Substring(0, 1).ToLower() == "y")
                    continue;
                else
                    break;
            }
        }
    }
}
