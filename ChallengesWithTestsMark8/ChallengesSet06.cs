using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lowercase = words.Select(x => x.ToLower()).ToList();
                containsWord = lowercase.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            bool primeNumber = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    primeNumber = true;
                }
            }
            if (num == 1)
            {
                primeNumber = false;
            }
            if (num == 2 || num == 3)
            {
                primeNumber = true;
            }
            return primeNumber;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            for (int i = 0; i < str.Length; i++)
            {
                var uniqueIndex = true;
                
                for (int x = 0; x < str.Length; x++)
                {
                    if (str[i] == str[x] && i != x)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int consecutiveCount = 0;
            
            for (var i = 0; i < numbers.Length; i++)
            {
                var countTally = 1;

                for (var x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] != numbers[x])
                    {
                        break;
                    }
                    countTally++;
                }
                if (countTally > consecutiveCount)
                {
                    consecutiveCount = countTally;
                }
            }
            return consecutiveCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElements = new List<double>();
            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElements.ToArray();
            }
            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElements.Add(elements[i]);
            }
            return nthElements.ToArray();
        }
    }
}
