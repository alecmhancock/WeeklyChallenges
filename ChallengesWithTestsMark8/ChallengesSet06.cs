using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null || words.Contains(null))
            {
                return false;
            }
            foreach (var item in words)
            {
                if (ignoreCase == true)
                {
                    if (item.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                    
                }
                else
                {
                    if (item == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
            

        

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
       

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null)
            {
                return -1;
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                int count = 0;
                for (int j = str.Length - 1; j >= 0; j--)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    return i;
                }
            }
            return -1;
        }
      

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break; 
                    }
                    else
                    {
                        currentCount++;
                    }
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }
            var result = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
        }
    }

