using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.Test
{
    [TestFixture]
    class StringCalculatorTest
    {
        [Test]
        public void Add_EmptyString_Zero()
        {
            StringCalculator calc = new StringCalculator();

            int sum = calc.Add("");

            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Add_SingleNumber_ReturnNumber()
        {
            StringCalculator calc = new StringCalculator();

            int sum = calc.Add("1");

            Assert.AreEqual(1, sum);
        }

        [Test]
        public void Add_TwoNumbers_ReturnSum()
        {
            StringCalculator calc = new StringCalculator();

            int sum = calc.Add("1,2");

            Assert.AreEqual(3, sum);
            
        }
        [TestCase("3", 3)]
        [TestCase("1,2,3", 6)]
        public void Add_Unknown_ReturnSum(string numbers, int expected)
        {
            StringCalculator calc = new StringCalculator();

            int sum = calc.Add(numbers);

            Assert.AreEqual(expected, sum);
        }
    }
}
