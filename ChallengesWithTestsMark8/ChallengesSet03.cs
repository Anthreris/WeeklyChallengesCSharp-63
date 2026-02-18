using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else //else still not used?
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;

            foreach (var letter in password)
            {
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
                if (char.IsLower(letter))
                {
                    isLower = true;    
                }

                if (char.IsNumber(letter))
                {
                    isNumber = true;
                }
            }
            return isUpper && isLower && isNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            return nums[nums.Length - 1] - nums[0];;
        }

        public int[] GetOddsBelow100()
        {
            var oddsList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsList.Add(i);
                    i++;
                }
            }
            return oddsList.ToArray();

            // Still refactoring this version
            // int[] arrayForOdds
            // int[] arrayForOdds = new int[];
            // for (var i = 0; i < 100; i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         arrayForOdds[100] = i;
            //         i++;
            //     }
            // }
            // return arrayForOdds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
