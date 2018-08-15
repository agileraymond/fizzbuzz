using System;

namespace FizzBuzzRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzz = new Game.FizzBuzz();
            var results = fizzbuzz.Run(1, 100);
        }
    }
}
