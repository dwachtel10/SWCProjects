using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollections.Collections
{
    public class Generics
    {
        public void ShowStack()
        {
            Console.WriteLine("<= Generic Show Stack");

            Stack<string> teams = new Stack<string>();

            teams.Push("Browns");
            teams.Push("Indians");
            teams.Push("Cavs");

            int count = teams.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(teams.Pop());
            }
        }

        public void SimpleList()
        {
            Console.WriteLine("<= Simple List");

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.AddRange(new int[] { 5, 4, 3, 2 });
            numbers.Insert(2, 100);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            numbers.Remove(4);
            numbers.RemoveAt(0);
            numbers.RemoveRange(0, 2);


        }

        public void PersonDictionary()
        {
            Console.WriteLine("<= Person Dictionary");

            Dictionary<string, Person> people = new Dictionary<string, Person>();

            people.Add("Balzer", new Person() { FirstName = "Dave", LastName = "Balzer" });
            people.Add("Toner", new Person() { FirstName = "Pat", LastName = "Toner" });
            people.Add("Clapper", new Person() { FirstName = "Randall", LastName = "Clapper" });

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}, {person.Value.FirstName}");
            }
        }
    }
}
