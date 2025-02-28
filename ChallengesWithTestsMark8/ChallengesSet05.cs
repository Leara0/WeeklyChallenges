using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int answer = startNumber+1;
            while (answer % n != 0)
            {
                answer++;
            }

            return answer;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
                if (businesses[i].TotalRevenue == 0)
                    businesses[i].Name = "CLOSED";
            Console.WriteLine(businesses[0].Name + " " + businesses[0].TotalRevenue);
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            var counter = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1] || numbers[i] == numbers[i + 1])
                    counter++;
            }

            return (counter == numbers.Length - 1);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if (numbers == null || numbers.Length == 0)
                return 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (Math.Abs(numbers[i]) % 2 == 0)
                    sum += numbers[i+1];
            }

            return sum;
        }


        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";
            string answer = "";
            for (var i = 0; i<words.Length; i++)
            {
                if (words[i] != " " && words[i] != "" && words[i] != "  ")
                    answer += words[i].Trim() + " ";
            }
            answer = answer.Trim() + ".";
            if (answer == ".")
                return "";
            return answer;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
                return new double[0];
            List<double> result = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i+1) % 4 == 0)
                    result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool canSum = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }

            return false;
        }
    }
}