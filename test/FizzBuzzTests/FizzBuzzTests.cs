using System;
using Xunit;
using Game;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void FizzBuzz_PrintFizzBuzz_WhenNumberIs15()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.Run(15);

            Assert.True(results[14] == "fizzbuzz");
        }
    }
}
