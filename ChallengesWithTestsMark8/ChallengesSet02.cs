using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            return lowercaseAlphabet.ToLower().Contains(c);    
            //why doesn't this work?
        }

        public bool CountOfElementsIsEven(string[] vals)
        
             => vals.Length % 2 == 0 ? true : false; 
        

        public bool IsNumberEven(int number)
        => number % 2 == 0 ? true : false;

        public bool IsNumberOdd(int num)
        => num % 2 != 0 ? true : false;

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            var yeow = numbers.ToString();
            if (yeow != string.Empty && numbers != null)
                return numbers.Max() + numbers.Min();
            else return 0;
          
              
//return numbers IsNullorEmpty != null && !"" ? numbers.Max() + numbers.Min() : 0;
        }//why doesnt this work?

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            return numbers != null ? numbers.Sum() : 0;
            
        }

        public int SumEvens(int[] numbers)
        {
            var listy = new List<int>();
            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        listy.Add(num);
                    }
                }
                return listy.Sum();
            }
            else return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            else if (numbers.Sum() % 2 != 0)
                return true;
            else return false;                
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
