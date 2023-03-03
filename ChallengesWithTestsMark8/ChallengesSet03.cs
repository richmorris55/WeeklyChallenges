using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++ ) 
            {
                if (vals[i] == false)
                {
                    return true;
                }

                
            }
            return false;
                
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
          
            if (numbers == null || !numbers.Any())
            {
                return false;
            }

            List<int> oddNumbersList = new List<int>();
            var numberArray = numbers.ToArray();

            for (int i = 0; i < numberArray.Length; i++)
            {
                var number = numberArray[i];
                if (number % 2 != 0)
                {
                    oddNumbersList.Add(number);
                }
            };

            var sum = oddNumbersList.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }

            //var linqSum = numbers.Select(x => x).Where(x => x % 2 != 0).Sum();

            //return linqSum % 2 != 0 ? true :false;

            return false; 
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool UpperCase = false;
            bool LowerCase = false;
            bool Number = false;

            foreach (char x in password)
            {
                if (char.IsUpper(x))
                {
                    UpperCase = true;
                }

                else if (char.IsLower(x))
                {
                     LowerCase = true;
                }

                else if (char.IsDigit(x))
                {
                    Number = true;
                }

                
            }

            return UpperCase && LowerCase && Number;



        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0]; 
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[val.Length - 1];

            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
           
            if(divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }   

        public int LastMinusFirst(int[] nums)
        {
            int first = nums[0];
            int last = nums[nums.Length - 1];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int index = 0;

            for (int i = 1; i < 100; i += 2)
            {
                odds[index] = i;
                index++;
            }

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }

            
        }
    }
}
