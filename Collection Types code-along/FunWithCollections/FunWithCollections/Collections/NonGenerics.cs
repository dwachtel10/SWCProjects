using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollections.Collections
{
    public class NonGenerics
    {
        public static void ShowArrayList()
        {
            Console.WriteLine("<= Show ArrayList");

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add(123);

            Person p1 = new Person();
            p1.FirstName = "Douglas";
            p1.LastName = "Wachtel";
            arrayList.Add(p1);

            foreach(object o in arrayList)
            {
                Console.WriteLine(o);
            }
        }

        public static void ShowHashTable()
        {
            Console.WriteLine("<= Show HashTable");

            Hashtable map = new Hashtable();

            map.Add(1, "hello");
            map.Add("world", 234235123.45);
            map.Add(true, new Person() { FirstName = "Bart", LastName = "Simpson" });

            foreach(var key in map.Keys)
            {
                Console.WriteLine($"{key} - {map[key]}");
            }
        }

        public static void ShowStack()
        {
            Console.WriteLine("<= Show Stack");

            Stack name = new Stack();

            name.Push("Hello");
            name.Push("123");
            name.Push(new Person() { FirstName = "Marge", LastName = "Simpson" });

            int count = name.Count;
            for(int i=0; i < count; i++)
            { Console.WriteLine(name.Pop()); }
        }

        public static void ShowQueue()
        {
            Console.WriteLine("<= Show Queue");

            Queue myQ = new Queue();

            myQ.Enqueue("Hello");
            myQ.Enqueue(123);

        }
    }
}
