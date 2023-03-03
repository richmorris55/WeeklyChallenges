using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }
            return result;
        }



        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string shortestString = str1;

            if (str2.Length < shortestString.Length)
            {
                shortestString = str2;
            }

            if (str3.Length < shortestString.Length)
            {
                shortestString = str3;
            }

            if (str4.Length < shortestString.Length)
            {
                shortestString = str4;

            }
            return shortestString.Length;

        }



        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;

            if (number2 < smallest)
            {
                smallest = number2;
            }

            if (number3 < smallest)
            {
                smallest = number3;
            }

            if (number4 < smallest)
            {
                smallest = number4;
            }

            return smallest;
        }



        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

                biz.Name = "TrueCoders";

        }



        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                
                return false;
            }

           
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }

            
            return true;
        }
        
           
        public bool IsStringANumber(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }



        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int nonNullCount = 0;

            foreach (object element in objs)
            {
                if (element == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }

            return nullCount > nonNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int count = 0;
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                    sum += number;
                }
            }

            if (count == 0)
            {
                return 0;
            }
            else
            {
                return (double)sum / count;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
        
    }
 }
