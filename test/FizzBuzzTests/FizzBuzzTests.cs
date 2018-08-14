using System;
using Xunit;
using Game;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void FizzBuzz_PrintsFizzBuzz_WhenNumberIs15()
        {
            var fizzBuzz = new FizzBuzz();            
            Assert.True(fizzBuzz.CheckNumber(15) == "fizzbuzz");
        }

        [Fact]
        public void CheckNumber_Returnsfizz_WhenNumberIs3()
        {
            var fizzBuzz = new FizzBuzz();            
            Assert.True(fizzBuzz.CheckNumber(3) == "fizz");
        }

        [Fact]
        public void FizzBuzz_RunMethod_Generates5Strings_WhenNumbersAre1to5()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.Run(1, 5);
            Assert.True(results.Count == 5);
        }
    }
}
