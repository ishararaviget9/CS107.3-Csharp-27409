/*
Add a separate class file to Console application program and create a method call private void 
sayHello().
Inside the method display hello world.
In main class create object and try to access the sayHello() method by using the class object.
Can you access the method? Explain why?
*/


// The `SayHello` class
public class SayHello
{
    private void sayHello()
    {
        Console.WriteLine("Hello, world!");
    }
}

// The `Main` class
public class Main
{
    static void Main(string[] args)
    {
        // Create a class object
        var sayHello = new SayHello();

        // Try to access the `sayHello()` method
        try
        {
            sayHello.sayHello();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}