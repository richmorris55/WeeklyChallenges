using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder = startNumber % n;

            if (startNumber < 0)
            {
                // If startNumber is negative, calculate the previous multiple of n.
                return startNumber - remainder;
            }
            else
            {
                // Calculate the next multiple of n greater than or equal to startNumber.
                return startNumber + (n - remainder);
        }   }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0; // return 0 if array is null 
            }

            int sum = 0;
            bool foundEven = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)  // if even number found
                {
                    foundEven = true;
                    sum += numbers[i + 1]; // add next element to sum
                }
            }

            return foundEven ? sum : 0;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            int goodwords = 0;
            List<string> wordslist = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().Length > 0)
                {
                    wordslist.Add(words[i].Trim() + " ");

                    goodwords++;
                }
            }
            
            if (goodwords == 0)
            {
                return "";
            }
            else
            {
                return String.Join("", wordslist). Trim() + ".";
            }

        }
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double [0];
            }

            int numElements = elements.Count / 4;
            double[] result = new double[numElements];
            int j = 0;

            for (int i = 3; i < elements.Count; i += 4)
            {
                result[j] = elements[i];
                j++;
            }

            return result;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
