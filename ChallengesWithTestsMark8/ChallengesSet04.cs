using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 < number2 && number1 < number3 && number1 < number4)
            {
                return number1;
            } else if (number2 < number1 && number2 < number3 && number2 < number4)
            {
                return number2;
            } else if (number3 < number1 && number3 < number2 && number3 < number4)
            {
                return number3;
            } else if (number4 < number1 && number4 < number2 && number4 < number3)
            {
                return number4;
            }
            return 0; //Works but this shouldn't be the return statement
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
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
