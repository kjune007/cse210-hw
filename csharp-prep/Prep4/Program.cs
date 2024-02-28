using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool flag = false;

        while(flag == false)
        {
            Console.Write("Add a number to the list (enter 0 when done): ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput); 

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                flag = true;
            }
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The avverage of the list is: {average}");
        Console.WriteLine($"The largest integer is {max}");
        Console.WriteLine($"The smallest number is {min}");
        
        numbers.Sort();

        Console.WriteLine("The list from smallest to largest is: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            int value = numbers[i];
            Console.WriteLine($"{value}");
        }


    }
}