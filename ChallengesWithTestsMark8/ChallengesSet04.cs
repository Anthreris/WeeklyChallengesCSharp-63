using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                if (number % 2 != 0)
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            // var list = new List<int>(){str1.Length, str2.Length, str3.Length, str4.Length};
            // return list.Min();
            
             var shortestLength = str1.Length;
             
             if (shortestLength > str2.Length)
             {
                 shortestLength = str2.Length;
             } 
             if (shortestLength > str3.Length)
             {
                 shortestLength = str3.Length;
             } 
             if (shortestLength > str4.Length)
             {
                 shortestLength = str4.Length;
             } 
             if  (shortestLength > str1.Length)
             {
                 shortestLength = str1.Length;
             }
             return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
            
            // Below GetSmallestNumber code doesn't work even after various renditions.
            
            //var smallestNumber = number1;
            //if (smallestNumber > number2) //&& smallestNumber > number3 && smallestNumber > number4)
            //{
            //    smallestNumber = number2;
            //} else if (smallestNumber > number3) //&& smallestNumber > number3 && smallestNumber > number4)
            //{
            //    smallestNumber = number3;
            //} else if (smallestNumber > number4) //&& smallestNumber > number2 && smallestNumber > number4)
            //{
            //    smallestNumber = number4;
            //} else if (smallestNumber > number1) //&& smallestNumber > number2 && smallestNumber > number3)
            //{
            //    smallestNumber = number1;
            //}
            //return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            } return false;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number); //Can't be int due to decimal values
            
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majorityElements = (amount / 2) + 1;
            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            } 
            if (count >= majorityElements)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double numberOfEvens = 0;
            
            if (numbers == null)
            {
                return 0;
            }
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    numberOfEvens++;
                }
            }
            if (numberOfEvens > 0)
            {
                return sum / numberOfEvens;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            var fact = 1;
            
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
