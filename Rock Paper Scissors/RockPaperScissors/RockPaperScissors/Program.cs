using RockPaperScissors.Enums;
using RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {


        static void Main(string[] args)
        {
            GamePlay();

        }

        static void GamePlay()
        {

            new Player = Player
            var p1choice = Choice.Unknown;
            bool validChoice = false;
            Console.WriteLine("${p1.Name}, please choose R(ock), P(aper), or S(cissors)");
            string choice = Console.ReadLine();
            do
            {
                switch (choice)
                {
                    case "R":
                        p1choice = Choice.Rock;
                        validChoice = true;
                        break;

                    case "P":
                        p1choice = Choice.Paper;
                        validChoice = true;
                        break;

                    case "S":
                        p1choice = Choice.Scissors;
                        validChoice = true;
                        break;

                    default:
                        p1choice = Choice.Unknown;
                        Console.WriteLine("Please pick R, P, or S.");
                        continue;
                }
            }
            while (validChoice == false);

            if (p1choice == Choice.Rock)
            {
                switch (p2choice)
                {
                    case Choice.Rock:
                        Console.WriteLine("It's a tie!  Play again?");
                        break;

                    case Choice.Paper:
                        Console.WriteLine($"{p2.Name} wins!  Play again?");
                        break;

                    case Choice.Scissors:
                        Console.WriteLine($"{p1.Name} wins!  Play again?");
                        break;

                    default:
                        Console.WriteLine($"Uh-oh! {p2.Name} goofed!  Let's try again.");
                        break;

                }


            }

            if (p1choice == Choice.Paper)
            {
                switch (p2choice)
                {
                    case Choice.Paper:
                        Console.WriteLine("It's a tie!  Play again?");
                        break;

                    case Choice.Rock:
                        Console.WriteLine($"{p2.Name} wins!  Play again?");
                        break;

                    case Choice.Scissors:
                        Console.WriteLine($"{p1.Name} wins!  Play again?");
                        break;

                    default:
                        Console.WriteLine($"Uh-oh! {p2.Name} goofed!  Let's try again.");
                        break;

                }
            }

            if (p1choice == Choice.Scissors)
            {
                switch (p2choice)
                {
                    case Choice.Scissors:
                        Console.WriteLine("It's a tie!  Play again?");
                        break;

                    case Choice.Rock:
                        Console.WriteLine($"{p2.Name} wins!  Play again?");
                        break;

                    case Choice.Paper:
                        Console.WriteLine($"{p1.Name} wins!  Play again?");
                        break;

                    default:
                        Console.WriteLine($"Uh-oh! {p2.Name} goofed!  Let's try again.");
                        break;

                }
            }
        }
}


