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
            int number = int.Parse(wordNumber);    
            return number;
            //int.TryParse(wordNumber, out number);
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
    }
}
