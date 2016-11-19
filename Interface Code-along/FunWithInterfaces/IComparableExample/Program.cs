using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatures = new Temperature[]
            {
                new Temperature() {Fahrenheit =71},
                new Temperature() {Fahrenheit = 80.9 },
                new Temperature() {Fahrenheit = 69.2 },
                new Temperature() {Fahrenheit = 451 }
            };

            Array.Sort(temperatures);

            foreach (var temp in temperatures)
            {
                Console.WriteLine($"{temp.Fahrenheit} {temp.Celsius:0.00}");
            }

            Console.ReadLine();
            }

        }
    }

