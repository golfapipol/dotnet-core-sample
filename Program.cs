using System;

namespace dotnet_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Hello World
            Console.WriteLine("Hello World!");
            // Declare Variable
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            Console.WriteLine($"Hello World contains world? : {sayHello.Contains("World")}");
            Console.WriteLine($"Hello World is Start with Hello ? {sayHello.StartsWith("Hello")}");
            Console.WriteLine($"Hello World is Start with hello ? {sayHello.StartsWith("hello")}");
            Console.WriteLine($"Hello World is End with World ? {sayHello.StartsWith("World!")}");
            Console.WriteLine($"Hello World is End with world ? {sayHello.StartsWith("world!")}");

            // String Length
            string aFriend = "Jonny";
            Console.WriteLine($"Hello {aFriend}, That name is length {aFriend.Length}");

        }
    }
}
