using System;
/*
 * The sum of the squares of the first ten natural numbers is,
 * 12 + 22 + ... + 102 = 385
 * The square of the sum of the first ten natural numbers is,
 * (1 + 2 + ... + 10)2 = 552 = 3025
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 * 
 * Just simple one cycle run.
 */
namespace PEProblem006
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int sumSquare = 0;
            int squareSum = 0;
            for (int i = 1; i < 101; i++)
            {
                sumSquare += (i * i);
                squareSum += i;
            }
            squareSum = squareSum * squareSum;
            int result = squareSum - sumSquare;

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
