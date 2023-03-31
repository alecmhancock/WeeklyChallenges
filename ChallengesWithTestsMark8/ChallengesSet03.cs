using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var odds = new List<int>();
            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                {
                    odds.Add(n);
                }
            }
            var answer = odds.Sum();
            return answer % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var lower = false;
            var upper = false;
            var num = false;
            for (var i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    lower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    lower = true;
                }
            }
            return password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsNumber);
        }
    


        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend== 0 || divisor == 0)
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
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i  = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
