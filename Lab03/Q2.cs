// 2. Count the number of vowels in a string

using System;

public class Vowels
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int vowels = 0;

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                vowels++;
            }
        }

        Console.WriteLine("Number of vowels: " + vowels);
    }
}