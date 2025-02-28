using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Count() == 0)
                return false;
            foreach (string wor in words)
            {
                if (wor != null)
                {
                    if (ignoreCase)
                    {
                        if (wor.ToLower() == word.ToLower())
                            return true;
                    }
                    else if (wor == word)
                        return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == -1 || num == 0 || num == 1)
                return false;
            if (num > 0)
                for (var i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }

            if (num < 0)
                return false;

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null || str.Length == 0)
                return -1;
            char[] letters = new char[7] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            char uniqueLetter = '1';
            for (var i = 0; i < letters.Length; i++)
            {
                if (str.IndexOf(letters[i]) == str.LastIndexOf(letters[i]))
                {
                    uniqueLetter = letters[i];
                    return str.IndexOf(uniqueLetter);
                }
            }

            return str.IndexOf(uniqueLetter);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count;
            int max = 1;
            for (var i = 0; i < numbers.Length; i++)
            {
                count = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        count++;
                    else
                        break;
                }

                max = Math.Max(max, count);
            }

            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n < 1 || elements == null || elements.Count == 0)
                return new double[0];
            List<double> elementsList = new List<double>();
            for (var i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                    elementsList.Add(elements[i]);
            }

            return elementsList.ToArray();
        }
    }
}