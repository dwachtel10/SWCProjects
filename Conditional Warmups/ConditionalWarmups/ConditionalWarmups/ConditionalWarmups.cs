using System;

namespace ConditionalWarmups
{
    public class ConditionalWarmups
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return (aSmile == bSmile);

          
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            bool CanSleepIn = false;

            if (!isWeekday || isVacation)
            {
                return !CanSleepIn;
            }
            else
            {
                return CanSleepIn;
            }
        }

        public int SumDouble(int a, int b)
        {
            if (a == b)

            {

                return a + b + a + b;

            }
            else

            {
                return a + b;
            }

        }

        public int Diff21(int n)
        {
            if (n <= 21)
            {
                return 21 - n;
            }
            else
            {
                return (n - 21) * 2;
            }
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (hour < 7 || hour > 20)
            {
                if (isTalking == true)
                {
                    return true;

                }
                else
                {

                    return false;

                }

            }
            else
            {

                return false;
            }


        }

        public bool Makes10(int a, int b)
        {
            if (a + b == 10 || a == 10 || b == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool NearHundred(int n)
        {
            if (n >= 90 && n <= 110 || n >= 190 && n <= 210)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            if (negative == true)
            {
                if (a < 0 && b < 0)
                {
                    return true;
                }

                else if (a < 0 || b < 0 & !(a < 0 && b < 0))
                {

                    return false;
                }

                else
                {

                    return false;
                }
            }
            else if (negative == false)
            {
                if (a < 0 || b < 0 & !(a < 0 && b < 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string NotString(string s)
        {
            if (s.Length < 3)
            { return "not " + s; }
            else
            {
                string firstThree = s.Substring(0, 3);
                if (firstThree == "not")
                {
                    return s;
                }
                else
                {
                    return "not " + s;
                }
            }

        }

        public string MissingChar(string str, int n)
        {
            if (n != 0)
            {
                string substring1 = str.Substring(0, n);
                string substring2 = str.Substring(n + 1);
                return substring1 + substring2;
            }
            else if (n == 0)
            {
                string substring3 = str.Substring(1);
                return substring3;
            }

            else
            {
                return str;
            }

        }

        public string FrontBack(string str)
        {
            if (str.Length == 1)
            {
                return str;
            }

            else if (str.Length == 2)
            {
                string substring1 = str.Substring(0, 1);
                string substring2 = str.Substring(str.Length - 1);

                return substring2 + substring1;
            }

            else
            {
                string substring1 = str.Substring(0, 1);
                string substring2 = str.Substring(str.Length - 1);
                string substring3 = str.Substring(1, str.Length - 2);

                return substring2 + substring3 + substring1;
            }
        }

        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }

            else
            {
                string substring1 = str.Substring(0, 3);
                return substring1 + substring1 + substring1;
            }
        }

        public string BackAround(string str)
        {
            if (str.Length == 1)
            {
                return str + str + str;
            }

            else
            {
                string substring1 = str.Substring(str.Length - 1);
                return substring1 + str + substring1;
            }
        }

        public bool Multiple3or5(int number)
        {
            if (number % 3 == 0)
            {
                return true;
            }

            else if (number % 5 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool StartHi(string str)
        {
            string substring1 = str.Substring(0, 2);

            if (str.Length <= 2)
            {
                if (str == "hi")
                {
                    return true;

                }

                else
                {
                    return false;
                }


            }

            else if (str.Length > 2)
            {
                string substring2 = str.Substring(2, 1);

                if (substring1 == "hi" & (substring2 == " "))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool IcyHot(int temp1, int temp2) //consider this one for code review
        {
            if (((temp1 > 100 || temp2 > 100) & !(temp1 > 100 && temp2 > 100)) & ((temp1 < 0 || temp2 < 0) & !(temp1 < 0 && temp2 < 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Between10and20(int a, int b)
        {
            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasTeen(int a, int b, int c)
        {
            if ((a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool SoAlone(int a, int b)
        {
            if (((a >= 13 && a <= 19) || (b >= 13 && b <= 19)) & !((a >= 13 && a <= 19) && (b >= 13 && b <= 19)))
            { return true; }
            else
            {
                return false;
            }
        }

        public string RemoveDel(string str)
        {
            string isItDel = str.Substring(1, 3);
            if (isItDel == "del")
            {
                string firstLetter = str.Substring(0, 1);
                string theRest = str.Substring(4);
                return firstLetter + theRest;
            }
            else
            {
                return str;
            }

        }

        public bool IxStart(string str)
        {
            string isItIx = str.Substring(1, 2);
            if (isItIx == "ix")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string StartOz(string str)
        {
            string firstLetter = str.Substring(0, 1);
            string secondLetter = str.Substring(1, 1);
            if (firstLetter == "o")
            {
                if (secondLetter == "z")
                {
                    return firstLetter + secondLetter;
                }
                else
                {
                    return firstLetter;
                }
            }

            else if (secondLetter == "z")
            {
                return secondLetter;
            }

            else
            {
                return null;
            }
        }

        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }

            else
            {
                return c;
            }

        }

        public int Max(int a, int b)
        {
            int aDiff = Math.Abs(a - 10);
            int bDiff = Math.Abs(b - 10);
            if (aDiff < bDiff)
            {
                return a;
            }

            else if (aDiff > bDiff)
            {
                return b;
            }

            else
            {
                return 0;
            }


        }

        public bool GotE(string str)
        {
            int eCount = (str.Length - str.Replace("e", "").Length) / "e".Length; //I found this online and only have half an idea why it works, but it does.
            if (eCount >= 1 && eCount < 4)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string EndUp(string str)
        {
            if (str.Length < 3)
            {
                return str.ToUpper();
            }
            else
            {
                string endString = str.Substring(str.Length - 3);
                string frontString = str.Substring(0, str.Length - 3);
                return frontString + endString.ToUpper();
            }

        }

        public string EveryNth(string str, int n)
        {
            if (n * 3 > str.Length)

            {
                string substring1 = str.Substring(0, 1);
                string substring2 = str.Substring(n, 1);
                string substring3 = str.Substring(n * 2, 1);

                return substring1 + substring2 + substring3;
            }

            else
            {
                string substring1 = str.Substring(0, 1);
                string substring2 = str.Substring(n, 1);
                string substring3 = str.Substring(n * 2, 1);
                string substring4 = str.Substring(n * 3, 1);
                return substring1 + substring2 + substring3 + substring4;
            }


        }
    }
}

    

    

        
        
   

