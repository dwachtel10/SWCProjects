using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class StringsWarmups
    {

        public string SayHi(string name)
        {
            return $"Hello {name}!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string text)
        {
            return $"<{tag}>{text}</{tag}>";
        }

        public string InsertWord(string container, string word)
        {
            int startIndex = 0;
            int endIndex = 2;
            int length = 2;
            string substring1 = container.Substring(startIndex, length);
            string substring2 = container.Substring(endIndex, length);
            return substring1 + word + substring2;
        }

        public string MultipleEndings(string str)
        {
            string substring1 = str.Substring(str.Length - 2);
            return substring1 + substring1 + substring1;

        }

        public string FirstHalf(string str)
        {
            int HalfLength = str.Length / 2;
            int startIndex = 0;
            string substring1 = str.Substring(startIndex, HalfLength);
            return substring1;



        }

        public string TrimOne(string str)
        {
            int startIndex = 1;
            int trimLength = str.Length - startIndex - 1;
            string substring1 = str.Substring(startIndex, trimLength);
            return substring1;


        }

        public string LongInMiddle(string a, string b)
        {
            int aLength = a.Length;
            int bLength = b.Length;
            if (aLength > bLength)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
            }

        }
        public string RotateLeft2(string str)
        {
            string substring1 = str.Substring(0, 2);
            int startIndex = 2;
            string substring2 = str.Substring(startIndex);
            return substring2 + substring1;


        }
        public string RotateRight2(string str)
        {

            int right2 = str.Length - 2;
            string substring1 = str.Substring(right2);
            string substring2 = str.Substring(0, str.Length - 2);
            return substring1 + substring2;
        }

        public string TakeOne(string str, bool fromFront)
        {


            if (fromFront)
            {

                string substring1 = str.Substring(0, 1);
                return substring1;

            }

            else

            {
                string substring2 = str.Substring(str.Length - 1);
                return substring2;

            }


        }
        public string MiddleTwo(string str)
        {
            int startIndex = str.Length / 2 - 1;
            int length = 2;
            string substring1 = str.Substring(
            startIndex, length);
            return substring1;
        }

        public bool EndsWithLy(string str)
        {
            if (str.Length < 2)
            { return false; }
            else
            {
                int lastTwo = str.Length - 2;
                string substring1 = str.Substring(lastTwo);
                if (substring1 == "ly")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string FrontAndBack(string str, int n)
        {
            string grabFront = str.Substring(0, n);
            string grabBack = str.Substring(str.Length - n);
            return grabFront + grabBack;
        }

        public string TakeTwoFromPosition(string str, int n)
        {

            if (n + 2 > str.Length || n <= 0)

            {
                string substring1 = str.Substring(0, 2);
                return substring1;
            }
            else
            {
                string substring2 = str.Substring(n);
                string substring3 = str.Substring(n + 2);
                return substring2 + substring3;
            }
        }

        public bool HasBad(string str)
        {

            string substring1 = str.Substring(0, 3);
            string substring2 = str.Substring(1, 3);
            if (substring1 == "bad")
            {

                return true;
            }
            else if (substring2 == "bad")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string AtFirst(string str)
        {
            if (str.Length < 2)
            {
                string substring1 = str.Substring(0);
                return substring1 + "@";
            }
            else
            {
                string substring2 = str.Substring(0, 2);
                return substring2;
            }
        }
        public string LastChars(string a, string b)
        {

            if (a.Length == 0)
            {
                string firstLetter = "@";
                string lastLetter = b.Substring(b.Length - 1);
                return firstLetter + lastLetter;
            }
            else if (b.Length == 0)
            {
                string firstLetter = a.Substring(0, 1);
                string lastLetter = "@";
                return firstLetter + lastLetter;


            }
            else
            {
                string firstLetter = a.Substring(0, 1);
                string lastLetter = b.Substring(b.Length - 1);
                return firstLetter + lastLetter;
            }



        }

        public string ConCat(string a, string b)
        {
            if (a.Length == 0)
            {
                return b;
            }
            else if (b.Length == 0)
            {
                return a;
            }
            else
            {
                string lastLetter = a.Substring(a.Length - 1);
                string firstLetter = b.Substring(0, 1);
                if (lastLetter == firstLetter)

                {
                    string substring1 = a.Substring(0, a.Length - 1);
                    return substring1 + b;
                }

                else
                {
                    return a + b;
                }

            }
        }

        public string SwapLast(string str)
        {
            if (str.Length <= 2)
            {
                string substring1 = str.Substring(str.Length - 1);
                string substring2 = str.Substring(0, 1);
                return substring1 + substring2;
            }
            else
            {
                string substring3 = str.Substring(str.Length - 1);
                string substring4 = str.Substring(str.Length - 2, 1);
                string substring5 = str.Substring(0, str.Length - 2);
                return substring5 + substring3 + substring4;

            }

        }

        public bool FrontAgain(string str)
        {
            string substring1 = str.Substring(0, 2);
            string substring2 = str.Substring(str.Length - 2);
            if (substring1 == substring2)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                string shortA = a.Substring(a.Length - b.Length);
                return shortA + b;
            }
            else if (b.Length > a.Length)
            {
                string shortB = b.Substring(b.Length - a.Length);
                return a + shortB;
            }
            else
            {
                return a + b;
            }
        }

        public string TweakFront(string str)
        {
            string firstLetter = str.Substring(0, 1);
            string secondLetter = str.Substring(1, 1);
            string restOfWord = str.Substring(2);
            if (firstLetter == "a" && secondLetter == "b")
            {
                return str;
            }
            else if (firstLetter == "a")
            {
                return firstLetter + restOfWord;
            }
            else if (secondLetter == "b")
            {
                return secondLetter + restOfWord;
            }
            else
                return restOfWord;
                
        }

        public string StripX(string str)
        {
            string firstLetter = str.Substring(0, 1);
            string lastLetter = str.Substring(str.Length-1);
            string restOfWord = str.Substring(1, str.Length - 2);
            if (firstLetter == "x" && lastLetter == "x")
            {
                return restOfWord;
            } else if (firstLetter == "x") {
                return restOfWord + lastLetter;
            }
            else if (lastLetter == "x")
            {
                return firstLetter + restOfWord;
            } else
            {
                return str;
            }
        }

    }
}
    
