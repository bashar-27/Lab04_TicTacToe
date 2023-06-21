using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
        }

        static void StartGame()
        {

            Player p1 = new Player();
            Player p2 = new Player();

            p1.Name = "p1";

            p1.IsTurn = true;
            p1.Marker = "X";
            p2.Name = "Computer";
            p2.Marker = "O";

            p2.IsTurn = false;
            Game game1 = new Game(p1, p2);
            Player Winner = game1.Play();
            Console.WriteLine(Winner.Name);
            if (Winner != null)
            {
                Console.WriteLine($"{Winner.Name} is winner");

            }
            else
            {
                Console.WriteLine($"there is no winner ");

            }
            
        }
        //

        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

    }
}
