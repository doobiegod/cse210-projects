using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Enter your name:  ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Enter favorite number:  ");
            string userNumber = Console.ReadLine();
            int intNumber = int.Parse(userNumber);
            return intNumber;
        }
        static int SquareNumber(int squared)
        {
            squared = squared * squared;
            return squared;
        }
        static void DisplayResult()
        {
            string userName = PromptUserName();
            int number = PromptUserNumber();
            int squared = SquareNumber(number);
            Console.WriteLine($"Brother {userName}, the square of your number is {squared}");
        }
        static void Main()
        {
            DisplayWelcome();
            DisplayResult();
        }
        Main();
    }
}