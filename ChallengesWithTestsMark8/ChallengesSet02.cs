using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    /* IEnumerable<double> numbers =
    double answer =  */
    
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return Math.Abs(num) % 2 == 1;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return 0;
            double max = numbers.ElementAt(0);
            double min = numbers.ElementAt(0);

            foreach (double value in numbers)
            {
                max = Math.Max(max, value);
                min = Math.Min(min, value);
            }

            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == null)
                    numbers[i] = 0;
                sum += numbers[i];
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    sum += number;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers ==null)
                return false;
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            return Math.Abs(sum) % 2 == 1;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 1)
                    count++;
            }
            return count;
        }
    }
}