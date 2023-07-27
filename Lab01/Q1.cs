/*Create a Console application that can read your name and batch as an input and print 
them into the console.*/

// Console application to read name and batch as an input and print them into the console.

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the name and batch from the user.
            string name = Console.ReadLine();
            string batch = Console.ReadLine();

            // Print the name and batch to the console.
            Console.WriteLine("Your name is {0} and your batch is {1}.", name, batch);
        }
    }
}
