using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class FizzBuzz : IFizzBuzz
    {   
        public List<string> Run(int minNumber, int maxNumber)
        {
            ValidateNumbers(minNumber, maxNumber);
            return GetResults(minNumber, maxNumber);           
        }
        
        public List<string> Run(string minNumber, string maxNumber)
        {
            int min = ParseNumber(minNumber);
            int max = ParseNumber(maxNumber);
            ValidateNumbers(min, max);
            return GetResults(min, max);
        }

        public string CheckNumber(int number)
        {
            var result = new StringBuilder();
            if (number % 3 == 0) 
                result.Append("fizz");
            if (number % 5 == 0)
                result.Append("buzz");
            
            if (string.IsNullOrEmpty(result.ToString()))
                result.Append(number.ToString());

            Console.WriteLine(result.ToString());
            return result.ToString();
        }

        private void ValidateNumbers(int minNumber, int maxNumber)
        {
            if (minNumber < int.MinValue)
                throw new ArgumentException("Minimum number is not valid");
            
            if (maxNumber > int.MaxValue)
                throw new ArgumentException("Maximum number is not valid");

            if (minNumber > maxNumber)
                throw new ArgumentException("Minimum number must be less than maximum number");    
        }

        private int ParseNumber(string wordNumber)
        {
            if (string.IsNullOrEmpty(wordNumber))
                throw new NullReferenceException("number is null");

            // try to parse a number
            int number = 0;
            if (int.TryParse(wordNumber, out number))
                return number;
            
            // try to find a number 
            return FindNumber(wordNumber);
        }

        private List<string> GetResults(int minNumber, int maxNumber)
        {
            var results = new List<string>();  
                            
            for (int i = minNumber; i <= maxNumber; i++)
            {
                results.Add(CheckNumber(i));
            }            

            return results;
        }

        private int FindNumber(string wordNumber)
        {
            // using in memory Dictionary for now
            // research a better way to store these values
            var dictNumbers = new Dictionary<string, int>();
            dictNumbers.Add("one", 1);
            dictNumbers.Add("two", 2);
            dictNumbers.Add("three", 3);
            dictNumbers.Add("four", 4);
            dictNumbers.Add("five", 5);
            dictNumbers.Add("six", 6);
            dictNumbers.Add("seven", 7);
            dictNumbers.Add("eight", 8);
            dictNumbers.Add("nine", 9);
            dictNumbers.Add("ten", 10);

            if (dictNumbers.ContainsKey(wordNumber.ToLower()))
                return dictNumbers[wordNumber.ToLower()];

            throw new Exception("Unable to find a number");
        }
    }
}
