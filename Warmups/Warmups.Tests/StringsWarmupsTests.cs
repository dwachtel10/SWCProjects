using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Tests
{
    [TestFixture]
    class StringsWarmupsTests
    {
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.SayHi(name);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.Abba(a, b);
            Assert.AreEqual(expected, result);
        }
        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string tag, string text, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.MakeTags(tag, text);
            Assert.AreEqual(expected, result);
        }
        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWordTest(string container, string word, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.InsertWord(container, word);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndingsTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.MultipleEndings(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.FirstHalf(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOneTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.TrimOne(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddleTest(string a, string b, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.LongInMiddle(a, b);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateLeft2Test(string str, string expected)
        {

            StringsWarmups sw = new StringsWarmups();
            string result = sw.RotateLeft2(str);
            Assert.AreEqual(expected, result);

        }
        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2Test(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.RotateRight2(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]

        public void TakeOneTest(string str, bool fromFront, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.TakeOne(str, fromFront);
            Assert.AreEqual(expected, result);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]

        public void MiddleTwoTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.MiddleTwo(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        [TestCase("ly", true)]


        public void EndsWithLyTest(string str, bool expected)
        {
            StringsWarmups sw = new StringsWarmups();
            bool result = sw.EndsWithLy(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]


        public void FrontAndBackTest(string str, int n, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.FrontAndBack(str, n);
            Assert.AreEqual(expected, result);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]

        public void TakeTwoFromPositionTest(string str, int n, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.TakeTwoFromPosition(str, n);
            Assert.AreEqual(expected, result);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]

        public void HasBadTest(string str, bool expected)
        {
            StringsWarmups sw = new StringsWarmups();
            bool result = sw.HasBad(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]

        public void AtFirstTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.AtFirst(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]

        public void LastCharsTest(string a, string b, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.LastChars(a, b);
            Assert.AreEqual(expected, result);

        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCatTest(string a, string b, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.ConCat(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]

        public void SwapLastTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.SwapLast(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]

        public void FrontAgainTest(string str, bool expected)
        {
            StringsWarmups sw = new StringsWarmups();
            bool result = sw.FrontAgain(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]

        public void MinCatTest(string a, string b, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.MinCat(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]

        public void TweakFrontTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.TweakFront(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]

        public void StripXTest(string str, string expected)
        {
            StringsWarmups sw = new StringsWarmups();
            string result = sw.StripX(str);
            Assert.AreEqual(expected, result);
        }

    }

}