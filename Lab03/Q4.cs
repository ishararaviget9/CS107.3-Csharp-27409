// 4. Calculate the sum of all the odd numbers from 1 to a given positive integer

using System;

public class SumOfOddNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 3; i <= n; i += 2)
        {
            sum += i;
        }

        Console.WriteLine("Sum of odd numbers: " + sum);
    }
}