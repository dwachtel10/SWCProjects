using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            //prog.IterateString();
            //prog.SplitString();
            //prog.SimpleArray();
            //prog.ReverseString();
            //prog.DeclareImplicitArrays();
            prog.RectMultiDimensionalArray();
            Console.ReadLine();
        }

        public void IterateString()
        {
            string s1 = "This is a string of characters.\tmore";

            foreach (char c in s1)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(s1.Length);
              
        }

        public void SplitString()
        {
            string[] words = "This is a sentence.".Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);

            }
        }

        public void SimpleArray()
        {
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[2] = 300;

            for (int i = 0; i < myInts.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(myInts[i]);
                }
            }
        }

        public void ReverseString()
        {
            string myString = "String to Reverse";

            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[myString.Length - i - 1]);
            }
        }

        public void DeclareImplicitArrays()
        {
            
            var a = new[] { 1, 10, 100, 1000};
            Console.WriteLine($"a is a: {a.ToString()}");
        }

        public void RectMultiDimensionalArray()
        {
            int[,] grid = new int[10, 10];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    grid[i, j] = i * j;
                    Console.Write($"{grid[i,j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
