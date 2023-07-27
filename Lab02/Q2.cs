/*Write a Console Application to calculate sum, subtraction, multiplication and division 
of two user input numbers.*/

using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get two numbers from the user.
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum, subtraction, multiplication, and division of the two numbers.
            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number1 * number2;
            int quotient = number1 / number2;

            // Display the results to the user.
            Console.WriteLine("The sum of the two numbers is {0}.", sum);
            Console.WriteLine("The difference of the two numbers is {0}.", difference);
            Console.WriteLine("The product of the two numbers is {0}.", product);
            Console.WriteLine("The quotient of the two numbers is {0}.", quotient);
        }
    }
}