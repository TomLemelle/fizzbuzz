using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string FizzBuzzStr = "";
                if (i % 3 == 0) FizzBuzzStr += "Fizz "; 
                if (i % 5 == 0) FizzBuzzStr += "Buzz";
                Console.WriteLine($"{i} {FizzBuzzStr}");
            }
        }
    }
}
