/*Create a console application that can read two input values and show the summation 
of the inputs.
*/

// Console application to read two input values and show the summation of the inputs.

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the two input values from the user.
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            // Calculate the summation of the two input values.
            int sum = firstNumber + secondNumber;

            // Print the summation to the console.
Console.WriteLine("The summation of the two input values is {0}.",    sum);
        }
    }
}

