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
                return ""; // return empty string if input array is null or empty
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(words[0].Trim()); // add first trimmed word to string

            for (int i = 1; i < words.Length; i++)
            {
                sb.Append(string.IsNullOrWhiteSpace(words[i]) ? "" : " " + words[i].Trim());
            }

            sb.Append("."); // add a period at the end of the sentence
            return sb.ToString();

        }
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return null;
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
            throw new NotImplementedException();
        }
    }
}
