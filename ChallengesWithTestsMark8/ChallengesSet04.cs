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
            //
            // return list.Min();
            
            var shortestLength = str1.Length;
             if (shortestLength > str2.Length)
             {
                 shortestLength = str2.Length;
             } if (shortestLength > str3.Length)
             {
                 shortestLength = str3.Length;
             } if (shortestLength > str4.Length)
             {
                 shortestLength = str4.Length;
             } if  (shortestLength > str1.Length)
             {
                 shortestLength = str1.Length;
             }
             return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            // var smallestNumber = number1;
            // var list = new List<int>() { number1, number2, number3, number4 };
            //
            // for(int i = 0; i < list.Count; i++)
            // {
            //     
            // }
            throw new NotImplementedException();
            // if (number1 < number2 && number1 < number3 && number1 < number4)
            // {
            //     return number1;
            // } else if (number2 < number1 && number2 < number3 && number2 < number4)
            // {
            //     return number2;
            // } else if (number3 < number1 && number3 < number2 && number3 < number4)
            // {
            //     return number3;
            // } else if (number4 < number1 && number4 < number2 && number4 < number3)
            // {
            //     return number4;
            // }
            // return number1; //Works but this shouldn't be the return statement
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
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
