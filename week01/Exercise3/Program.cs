using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomNum = new Random();
        int magicNum = randomNum.Next(1, 100);

        int guess = 0;

        while (guess != magicNum)
        {

            Console.Write("What is your guess?  ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
    }
}