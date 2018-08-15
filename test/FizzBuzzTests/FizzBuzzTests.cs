using System;
using Xunit;
using Game;
using System.Linq;

namespace GameTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void CheckNumber_Returnsfizzbuzz_WhenNumberIs15()
        {
            var fizzBuzz = new FizzBuzz();            
            Assert.True(fizzBuzz.CheckNumber(15) == "fizzbuzz");
        }        

        [Fact]
        public void Run_ThrowsException_WithInvalidNumbers()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<ArgumentException>(() => fizzBuzz.Run(2, 1));
        }

        [Fact]
        public void CheckNumber_Returnsfizz_WhenNumberIs3()
        {
            var fizzBuzz = new FizzBuzz();            
            Assert.True(fizzBuzz.CheckNumber(3) == "fizz");
        }

        [Fact]
        public void CheckNumber_Returnsbuzz_WhenNumberIs5()
        {
            var fizzBuzz = new FizzBuzz();            
            Assert.True(fizzBuzz.CheckNumber(5) == "buzz");
        }

        [Fact]
        public void Run_Generates5Strings_WhenNumbersAre1to5()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.Run(1, 5);
            Assert.True(results.Count == 5);
        }

        [Fact]
        public void Run_ThrowsNullRefException_WhenStringNumberIsNull()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<NullReferenceException>(() => fizzBuzz.Run(null, null));
        }

        [Fact]
        public void Run_WorksAsExpected_WhenWordNumberExistInDictionary()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.Run("one", "ten");
            Assert.True(10 == results.Count);
        }
        
        [Fact]
        public void Run_ThrowsException_WhenWordNumbersDontExistInDictionary()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<Exception>(() => fizzBuzz.Run("a", "b"));
        }
        
        [Fact]
        public void Run_WorksAsExpected_WithMinValueAndMaxValue()
        {
            var fizzBuzz = new FizzBuzz();
            // todo: remove comments to run this test
            //var results = fizzBuzz.Run(int.MinValue, int.MaxValue);
            //Assert.True(results.Any());
        }
    }
}
