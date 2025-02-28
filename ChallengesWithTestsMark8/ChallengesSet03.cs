using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
                if (!val)
                    return true;
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            int answer = 0;
            foreach (int number in numbers)
                if (Math.Abs(number) % 2 == 1)
                    answer += number;

            return Math.Abs(answer) % 2 == 1;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    upper = true;
                if (char.IsLower(c))
                    lower = true;
                if (char.IsNumber(c))
                    number = true;
            }

            return upper && lower && number;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.ToCharArray()[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.ToCharArray()[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                    oddsList.Add(i);
            }

            return oddsList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}