using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                if (Math.Abs(number) % 2 == 0)
                    result += number;
                else
                    result -= number;
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var length1 = Math.Min(str1.Length, str2.Length);
            var length2 = Math.Min(str3.Length, str4.Length);
            return Math.Min(length1, length2);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallest1 = Math.Min(number1, number2);
            var smallest2 = Math.Min(number3, number4);
            return Math.Min(smallest1, smallest2);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 &&
                    sideLength3 + sideLength1 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var counter = 0;
            var lengthCounter = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                    counter++;
                
            }

            return (counter > objs.Length-counter);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            var sum = 0;
            var counter = 0;
            foreach (int number in numbers)
                if (Math.Abs(number) % 2 == 0)
                {
                    sum += number;
                    counter++;
                }

            if (counter == 0)
                return 0;

            return (double)sum / (double)counter;
        }

        public int Factorial(int number)
        {
            var product = number;
            for (int i = number - 1; i > 0; i--)
                product *= i;
            if (number == 0)
                return 1;
            if (number <0)
                throw new ArgumentOutOfRangeException();
            return product;
        }
    }
}