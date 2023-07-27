/*Upgrade the above console application which enables 10 user inputs and displays even 
or odd for each user input*/


using System;

namespace EvenOddChecker10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iterate 10 times to get 10 user inputs.
            for (int i = 0; i < 10; i++)
            {
                // Get a number from the user.
                int number = Convert.ToInt32(Console.ReadLine());

                // Check if the number is even or odd.
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} is even.", number);
                }
                else
                {
                    Console.WriteLine("{0} is odd.", number);
                }
            }
        }
    }
}