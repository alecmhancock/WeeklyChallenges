using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evenlist = new List<int>();
            var oddlist = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenlist.Add(numbers[i]);
                }
                else
                { 
                    oddlist.Add(numbers[i]);
                }
            }
            return evenlist.Sum() - oddlist.Sum();
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<string>();
            list.Add(str1); list.Add(str2); list.Add(str3); list.Add(str4);
            var answer = list.Min(x => x.Length);

            
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>();
            list.Add(number1); list.Add(number2); list.Add(number3); list.Add(number4);
            var answer = list.Min();
            return answer;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        { 
          return sideLength1 + sideLength2 > sideLength3 && 
                sideLength1 + sideLength3 > sideLength2 && 
                sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
           var numCheck = double.TryParse(input, out double number);
            return numCheck;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var elementCheck = objs.Count(x => x == null);
            return elementCheck > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {   
            double sum = 0;
            int count = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                foreach (var number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                        count++;
                    }
                }
                if (count == 0)
                {
                    return 0;
                }
                else
                {
                    return sum / count;
                }
            }
        }

        public int Factorial(int number)
        {
            var factCheck = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (number == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factCheck *= i;
                }
                return factCheck;
            }
        }
    }
}
