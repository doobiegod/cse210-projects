using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        string usrInput = "";
        Console.WriteLine("Enter a series of numbers, type 0 when finished.");

        while (usrInput != "0")
        {
            Console.Write("Enter a number:  ");
            usrInput = Console.ReadLine();
            if (usrInput != "0")
            {
                int userNum = int.Parse(usrInput);
                numbers.Add(userNum);
            }
        }

        int sum = 0;
        int itemNum = 0;
        int lrgNum = 0;

        Console.WriteLine("These are the numbers:");
        foreach (int num in numbers)
        {
            itemNum += 1;
            Console.WriteLine(num);
            sum = num + sum;

            if (num > lrgNum)
            {
                lrgNum = num;
            }
        }
        int avg = sum / itemNum;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is:  {avg}");
        Console.WriteLine($"The largest number is:  {lrgNum}");
    }
}