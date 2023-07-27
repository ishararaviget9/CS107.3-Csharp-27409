/*Write a Console Application to check if a given number is even or odd.*/


using System;

namespace EvenOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a number from the user.
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is even or odd.
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}