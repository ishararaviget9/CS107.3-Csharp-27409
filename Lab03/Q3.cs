// 3. Find the sum of the digits of a given number using a for loop

using System;

public class SumOfDigits
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; number > 0; i++)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}