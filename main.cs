using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, C#!");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
