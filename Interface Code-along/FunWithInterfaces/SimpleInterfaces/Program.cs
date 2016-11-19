using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanShepherd Bubble = new GermanShepherd();
            Console.WriteLine(Bubble.GoForAWalk());
            Bubble.Name = "Bubble";
            Bubble.Bark();



            //Console.ReadLine();

            List<IDog> dogs = new List<IDog>();
            dogs.Add(Bubble);
            dogs.Add(new Chihuahua("Butch"));

                Console.WriteLine();

            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog.Name} {dog.GoForAWalk()}");
                dog.Bark();
            }

            Console.ReadLine();
        }
    }
}
