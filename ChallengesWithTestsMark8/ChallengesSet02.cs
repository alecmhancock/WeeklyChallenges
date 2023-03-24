using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public static bool CharacterIsALetter(char c) => char.IsLetter(c);


    public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null)
            {
                return 0;
            }
            double min = 0;
            double max = 0;
            foreach (var num in numbers) 
            { 
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                if (numbers.Count() <= 1)
                {
                    min = num;
                }
            }
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var string1 = str1.Length;
            var string2 = str2.Length;
            if(string1 > string2)
            {
                return string2;
            }
            else
            {
                return string1;
            }
        }

        public  int Sum(int[] numbers)
        {
            if (numbers == null)
            { 
                return 0; 
            }
            
            var sum = 0;

            for(var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var evenSum = 0;
            for (var i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            var oddSum = 0;
            foreach (var num in numbers) 
            {
                oddSum += num;
            }
            return oddSum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
