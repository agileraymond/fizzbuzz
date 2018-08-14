using System;

namespace FizzBuzzRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzz = new Game.FizzBuzz();
            var max = int.MaxValue;
            var results = fizzbuzz.Run(20);

            Console.WriteLine("Hello World!");
        }
    }
}
