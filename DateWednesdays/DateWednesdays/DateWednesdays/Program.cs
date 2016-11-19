using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWednesdays
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            DateTime date = prog.PromptforDateTime();
            int number = prog.PromptforNumber();
            prog.PrintWednesdays(date, number);


            Console.ReadLine();
        }

        public DateTime PromptforDateTime()
        {
            DateTime enteredDate;
            string input = "";
            do
            {
                Console.Write("Please enter a date: ");
                input = Console.ReadLine();
            } while (!DateTime.TryParse(input, out enteredDate));


            return enteredDate;
        }

        public int PromptforNumber()
        {
            int enteredNumber;
            string input = "";
            do
            {
                Console.Write("Please enter a number of Wednesdays to print: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out enteredNumber));


            return enteredNumber;
        }

        public void PrintWednesdays(DateTime date, int numberOfWednesdays)
        {
            while(date.DayOfWeek != DayOfWeek.Wednesday)
            {
                date = date.AddDays(1);
            }

            for (int i =0; i < numberOfWednesdays; i++)
            {
                Console.WriteLine(date.ToShortDateString());
                date = date.AddDays(7);
            }
        }
    }
}
