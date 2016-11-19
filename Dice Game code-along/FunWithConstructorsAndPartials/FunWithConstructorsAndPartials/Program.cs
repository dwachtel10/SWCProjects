using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    class Program
    {
        static void Main(string[] args)
        {
            // create player 1 using default constructor
            Player p1 = new Player();
            // create player 2 passing the name
            Player p2 = new Player("Chungo");

            //object initializer

            GameWorkflow game = new GameWorkflow()
            {
                Player1 = p1,
                Player2 = p2
            };

            game.PlayGame();
            Console.ReadLine();
        }
    }
}
