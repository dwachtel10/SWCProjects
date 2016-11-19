using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWarmups.test
{
    public class ArraysTests
    {
        [TestCase(new int[]{ 1, 2, 6 }, true)]
        [TestCase(new int[]{ 6, 1, 2, 3 }, true)]
        [TestCase(new int[]{ 13, 6, 1, 2, 3 }, false)]

        public void FirstLast6Test(int[] numbers, bool expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            bool result = aw.FirstLast6(numbers);
            Assert.AreEqual(expected, result);

        }

        [TestCase(new int[] { 1, 2, 3}, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1}, true)]

        public void SameFirstLastTest(int[] numbers, bool expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            bool result = aw.SameFirstLast(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(3, new int[] { 3, 1, 4 })]

        public void MakePiTest(int n, int [] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.MakePi(n);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }, false)]
        [TestCase(new int[] {1, 2, 3 }, new int[] { 1, 3}, true)]

        public void CommonEndTest(int [] a, int [] b, bool expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            bool result = aw.CommonEnd(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3}, 6)]
        [TestCase(new int[] { 5, 11, 2}, 18)]
        [TestCase(new int[] { 7, 0, 0}, 7)]

        public void Sum(int[] numbers, int expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int result = aw.Sum(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 2, 3 }, new int[] { 2, 3, 1})]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 11, 9, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]

        public void RotateLeft(int[] numbers, int[] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.RotateLeft(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3}, new int[] { 3, 2, 1})]

        public void ReverseTest(int[] numbers, int[] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.Reverse(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3}, new int[] { 3, 3, 3, })]
        [TestCase(new int[] { 11, 5, 9}, new int[] { 11, 11, 11})]
        [TestCase(new int[] { 2, 11, 3}, new int[] { 3, 3, 3})]

        public void HigherWinsTest(int[] numbers, int[] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.HigherWins(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3}, new int[] { 4, 5, 6 }, new int[] { 2, 5 })]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }, new int[] { 7, 8 })]
        [TestCase(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }, new int[] { 2, 4 })]

        public void GetMiddleTest(int[] a, int[] b, int[] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.GetMiddle(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 5}, true)]
        [TestCase(new int[] { 4, 3}, true)]
        [TestCase(new int[] { 7, 5}, false)]

        public void HasEvenTest(int [] numbers, bool expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            bool result = aw.HasEven(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6})]
        [TestCase(new int[] { 1, 2}, new int[] { 0, 0, 0, 2})]
        [TestCase(new int[] { 3}, new int[] { 0, 3})]

        public void KeepLastTest(int[] numbers, int[] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.KeepLast(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 2, 3}, true)]
        [TestCase(new int[] { 3, 4, 5, 3}, true)]
        [TestCase(new int[] { 2, 3, 2, 2}, false)]

        public void Double23Test(int[] numbers, bool expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            bool result = aw.Double23(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3}, new int[] { 1, 2, 0})]
        [TestCase(new int[] { 2, 3, 5}, new int[] { 2, 0, 5})]
        [TestCase(new int[] { 1, 2, 1}, new int[] { 1, 2, 1})]

        public void Fix23Test(int[] numbers, int[] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.Fix23(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 3, 4, 5}, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5}, true)]
        [TestCase(new int[] { 1, 1, 1}, false)]

        public void Unlucky1Test(int[] numbers, bool expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            bool result = aw.Unlucky1(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 4, 5}, new int[] { 1, 2, 3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4,}, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] {}, new int[] { 1, 2}, new int[] { 1, 2 })]

        public void make2Test(int[] a, int[] b, int[] expected)
        {
            ArraysWarmups aw = new ArraysWarmups();
            int[] result = aw.make2(a, b);
            Assert.AreEqual(expected, result);
        }

    }
}
