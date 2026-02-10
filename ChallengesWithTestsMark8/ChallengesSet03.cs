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
            //Another attempt mimic'd from a video doesn't work? Is my program broken?
            int[] myArray = new int[100];
            int index = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    myArray[index] = i;
                    index++;
                }
            }
            return myArray;
            
            //My custom challenge attempt is below:
            
            // int[] arrayForOdds = new int[100];
            // int counting = 0;
            // for (int i = 0; i < 100; i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         arrayForOdds[counting] = i;
            //         counting++;
            //     }
            // }
            // return arrayForOdds;
            
            
            //Attempt based on a video
            
            // var oddsList = new List<int>();
            // for (int i = 0; i < 100; i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         list.Add(i);
            //     }
            // }
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
