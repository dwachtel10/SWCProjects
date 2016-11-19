using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    public class GameWorkflow
    {
        //properties
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        //private static readonly field
        //only inside of this class
        //only one
        //can set in constructor only
        private static readonly Random _randomGenerator;

        //static constructor 
        //can initialize the static properties and fields
        //cannot interact with instance of the class
        static GameWorkflow()
        {
            _randomGenerator = new Random();
        }

        public void PlayGame()
        {
            do
            {
                Player1.Score += RollDie();
                Player2.Score += RollDie();
            } while (Player1.Score < 100 && Player2.Score < 100);

            Console.WriteLine("GAME OVER");
            Console.WriteLine($"{Player1.Name} scored {Player1.Score} points");
            Console.WriteLine($"{Player2.Name} scored {Player2.Score} points");
            if (Player1.Score < Player2.Score)
            { Console.WriteLine($"{Player2.Name} is the winner!"); }
            else if (Player2.Score < Player1.Score) { Console.WriteLine($"{Player1.Name} is the winner!"); }
            else { Console.WriteLine("CHRIST ON HIS THRONE!  IT'S A TIE!"); }

        }
        //private method, only used from the Play Game method
        private int RollDie()
        {
            return _randomGenerator.Next(1, 7);
        }
    }
}
