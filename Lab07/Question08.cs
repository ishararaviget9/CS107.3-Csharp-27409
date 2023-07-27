/*
Create a Console application with two added classes called “Animal” and “Dog”. “Dog” is the 
derived class of ‘Animal Class’ (Base Class). Inside the ‘Animal Class’ Create a method which 
for ‘Dog’ Class. Inside the method print “I am Animal”. Inside the “Dog Class” Create a method 
and display “I have four legs”. Inside the main method create relevant class object and Display 
as follows. “I am an animal I have four legs”
*/

using System;

namespace AnimalDog
{
    class Animal
    {
        public void AnimalMethod()
        {
            Console.WriteLine("I am Animal");
        }
    }

    class Dog : Animal
    {
        public void DogMethod()
        {
            Console.WriteLine("I have four legs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.AnimalMethod();
            dog.DogMethod();
        }
    }
}