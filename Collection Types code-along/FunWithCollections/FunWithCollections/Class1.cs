using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunWithCollections.Collections;

namespace FunWithCollections
{
    public class Program
    {
        Program prog = new Program();

        static void Main(string[] args)
        {
            
            NonGenerics.ShowArrayList();
            NonGenerics.ShowHashTable();
            NonGenerics.ShowStack();
            NonGenerics.ShowQueue();
            

            Generics gen = new Generics();
            gen.ShowStack();
            gen.SimpleList();
            gen.PersonDictionary();

            Console.ReadLine();
        }
    }
}
