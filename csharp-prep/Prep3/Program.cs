using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int num = rnd.Next(1,100);
        bool flag = false;
        while (flag == false)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);
            if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("That's it!! ");
                flag = true;
            }

        }
    }
}