using System;
using System.Collections.Generic;

namespace Game
{
    public class FizzBuzz : IFizzBuzz
    {

        public List<string> Run(int upperBound)
        {
            var results = new List<string>();

            try
            {
                // validation
                if (upperBound < 2)
                    throw new Exception("upperBound must be greater than 1");
                            
                for (int i = 1; i <= upperBound; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        results.Add("fizzbuzz");
                    else if (i % 3 == 0)
                        results.Add("fizz");
                    else if (i % 5 == 0)
                        results.Add("buzz");
                    else
                        results.Add(i.ToString());
                }
            }
            catch (Exception ex)
            {

            }

            return results;
        }

    }
}
