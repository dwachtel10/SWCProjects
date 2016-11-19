using NUnit.Framework;
using ConditionalWarmups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalWarmups.test
{
    [TestFixture]
    class ConditionalWarmupsTest
    {
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.AreWeInTrouble(aSmile, bSmile);
            Assert.AreEqual(expected, result);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]

        public void CanSleepInTest(bool isWeekday, bool isVacation, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.CanSleepIn(isWeekday, isVacation);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDoubleTest(int a, int b, int expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            int result = cw.SumDouble(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21Test(int n, int expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            int result = cw.Diff21(n);
            Assert.AreEqual(expected, result);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTroubleTest(bool isTalking, int hour, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(expected, result);
        }


        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10Test(int a, int b, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.Makes10(a, b);
            Assert.AreEqual(expected, result);
        }


        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]

        public void NearHundredTest(int n, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.NearHundred(n);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]

        public void PosNegTest(int a, int b, bool negative, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.PosNeg(a, b, negative);
            Assert.AreEqual(expected, result);
        }
        
        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]

        public void NotStringTest(string s, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.NotString(s);
            Assert.AreEqual(expected, result);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]

        public void MissingCharTest(string str, int n, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.MissingChar(str, n);
            Assert.AreEqual(expected, result);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]

        public void FrontBackTest(string str, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.FrontBack(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]

        public void Front3Test(string str, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.Front3(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]

        public void BackAroundTest(string str, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.BackAround(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]

        public void Multiple3or5Test(int number, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.Multiple3or5(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]

        public void StartHiTest(string str, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.StartHi(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]

        public void IcyHotTest(int temp1, int temp2, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.IcyHot(temp1, temp2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]

        public void Between10and20Test(int a, int b, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.Between10and20(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]

        public void HasTeenTest(int a, int b, int c, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.HasTeen(a, b, c);
            Assert.AreEqual(expected, result);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]

        public void SoAloneTest(int a, int b, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.SoAlone(a, b);
            Assert.AreEqual(expected, result);
        }
        
        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]

        public void RemoveDelTest(string str, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.RemoveDel(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]

        public void IxStartTest(string str, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.IxStart(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]

        public void StartOzTest(string str, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.StartOz(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]

        public void MaxTest(int a, int b, int c, int expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            int result = cw.Max(a, b, c);
            Assert.AreEqual(expected, result);
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]

        public void CloserTest(int a, int b, int expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            int result = cw.Max(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]

        public void GotETest(string str, bool expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            bool result = cw.GotE(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]

        public void EndUpTest(string str, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.EndUp(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]

        public void EveryNthTest(string str, int n, string expected)
        {
            ConditionalWarmups cw = new ConditionalWarmups();
            string result = cw.EveryNth(str, n);
            Assert.AreEqual(expected, result);
        }
    }   






}
