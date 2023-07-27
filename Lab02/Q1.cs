/* Write a Console Application to calculate the sum of two user input numbers*/


using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get two numbers from the user.
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of the two numbers.
            int sum = number1 + number2;

            // Display the sum to the user.
            Console.WriteLine("The sum of the two numbers is {0}.", sum);
        }
    }
}