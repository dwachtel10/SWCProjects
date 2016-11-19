using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWarmups
{
    public class ArraysWarmups
    {
        public bool FirstLast6(int[] numbers)
        {
            bool isSix = false;
            foreach (int n in numbers)
            {
                if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
                {
                    isSix = true;
                }

                else isSix = false;
            }
            return isSix;

        }

        public bool SameFirstLast(int[] numbers)
        {
            bool sameN = false;
            if (numbers.Length < 1)
            {
                sameN = false;
            }

            foreach (int n in numbers)
            {
                if (numbers[0] == numbers[numbers.Length - 1])
                {
                    sameN = true;
                }
                else sameN = false;
            }

            return sameN;
        }

        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = (int)Math.Floor(pi);
                pi -= result[i];
                pi *= 10;
            }
            return result;
        }

        public bool CommonEnd(int[] a, int[] b)
        {
            bool match = false;
            if ((a[0] == b[0]) || (a[a.Length-1] == b[b.Length - 1]))
            {
                match = true;
            }
            return match;
        }

        public int Sum(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }

        public int[] RotateLeft(int[] numbers)
        {
            int[] rotated = new int[numbers.Length];

            for (int i = 0; i < numbers.Length -2 ; i++)
            {

                rotated[0] = numbers[1];
                rotated[1] = numbers[2];
                rotated[2] = numbers[0];

            }

            return rotated;
            
        }

        public int[] Reverse(int[] numbers)
        {
            int[] reverse = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            reverse[reverse.Length - 1 - i] = numbers[i];
            return reverse;
        }

        public int[] HigherWins(int[] numbers)
        {
            int[] highestArray = new int[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[0] > numbers[numbers.Length-1])
                {
                    highestArray[0] = numbers[0];
                    highestArray[1] = numbers[0];
                    highestArray[2] = numbers[0];
                }

                else if (numbers[0] < numbers[numbers.Length - 1])
                {
                    highestArray[0] = numbers[numbers.Length - 1];
                    highestArray[1] = numbers[numbers.Length - 1];
                    highestArray[2] = numbers[numbers.Length - 1];
                }
            }
            return highestArray;
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] middleTwo = new int[2];
            middleTwo[0] = a[1];
            middleTwo[1] = b[1];

            return middleTwo;

        }

        public bool HasEven(int[] numbers)
        {
            bool evens = false;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                    evens = true;
            }

            return evens;
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] keepLast = new int[numbers.Length * 2];
            keepLast[keepLast.Length - 1] = numbers[numbers.Length - 1];

            return keepLast;
        }

        public bool Double23(int[] numbers)
        {
            bool isDoubles = false;
            int twoCounter = 0;
            int threeCounter = 0;
            foreach(int n in numbers)
            {
                if (n == 2)
                {
                    twoCounter++;
                }

                if (n == 3)
                {
                    threeCounter++;
                }

            }
            if (twoCounter == 2 || threeCounter == 2)
            {
                isDoubles = true;

            }
            else
            {
                isDoubles = false;
            }


            return isDoubles;

        }
        //Given an int array length 3, if there is a 2 in the array immediately followed by a 3, 
        //set the 3 element to 0. Return the changed array.
        public int[] Fix23(int[] numbers)
        {
            
            int[] replaced = new int[numbers.Length];
            replaced[0] = numbers[0];
            for ( int i = 1; i < numbers.Length; i++)
            {
                
                if (numbers[i] == 3 && numbers[i -1] ==2)
                {
                    replaced[i] = 0;
                } else
                {
                    replaced[i] = numbers[i];
                }
                //if (numbers[2] == 3 && numbers[1] == 2)
                //{
                //    replaced[2] = 0;
                //}
                //else
                //{
                //    replaced[2] = numbers[2];
                //}


            }
            return replaced;
        }

        public bool Unlucky1(int[] numbers)
        {
            bool isUnlucky = false;
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if ((numbers[0] == 1 && numbers[1] == 3) || (numbers[1] == 1 && numbers[2] == 3) || (numbers[numbers.Length-2] == 1 && numbers[numbers.Length-1] == 3)){
                    isUnlucky = true;
                }
                
            }
            return isUnlucky;
        }

        public int[] make2(int[] a, int[] b)
        {
            int[] smallArr = new int[2];
            if (a.Length == 2)
            {
                smallArr[0] = a[0];
                smallArr[1] = a[1];
            }
            if (a.Length == 1)
            {
                smallArr[0] = a[0];
                smallArr[1] = b[0];
            }
            if (a.Length == 0)
            {
                smallArr[0] = b[0];
                smallArr[1] = b[1];
            }
            return smallArr;
        }
    }
}
