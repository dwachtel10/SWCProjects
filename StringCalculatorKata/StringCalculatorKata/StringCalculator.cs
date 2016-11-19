using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int sum = 0;

            if (string.IsNullOrEmpty(numbers)){
                sum = 0;
            }
            else
            {

                string[] numArray = numbers.Split(',');

                if (numArray.Length == 1)
                {
                    sum = int.Parse(numArray[0]);
                }
                else
                {
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        sum += int.Parse(numArray[i]);
                    }
          
                }

            }

            return sum;
        }

    }
}
