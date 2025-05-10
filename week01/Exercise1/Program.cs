using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("I am writing my first C# code :) ");

        Console.Write("What is your firstname?  ");
        string firstname = Console.ReadLine();
        Console.Write("What is your lasttname?  ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}