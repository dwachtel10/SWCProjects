using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    public class Temperature : IComparable
    {
        public double Fahrenheit { get; set; }
        public double Celsius { get { return (Fahrenheit - 32) * (5.0 / 9); } }

        public int CompareTo(object obj)
        {
            var otherTemp = obj as Temperature;

            if (otherTemp != null)
            {
                if (this.Fahrenheit < otherTemp.Fahrenheit)
                {
                    return 1;
                }
                else if (this.Fahrenheit == otherTemp.Fahrenheit)
                {
                    return 0;
                }
                else //this.Fahrenheit > otherTemp.Fahrenheit
                {
                    return -1;
                }
            }
            else
            {
                throw new ArgumentException("not a temp");
            }
        }
    }
}
