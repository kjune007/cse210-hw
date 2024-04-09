using System;

class Program
{
    static void Main(string[] args)
    {
        // Create List
        List<Activity> activity = new List<Activity>();

        // Create Activites
        Running Running1 = new Running();
        Cycling Cycling1 = new Cycling();
        Swimming Swimming1 = new Swimming();

        Running1.SetRunning(new DateTime(1998, 03, 02),32, 4.27);
        Cycling1.SetCycling(new DateTime(1998, 03, 07),27, 22);
        Swimming1.SetSwimming(new DateTime(1998, 03, 12),35,15);

        // Adding Activites to the List
        activity.Add(Running1);
        activity.Add(Cycling1);
        activity.Add(Swimming1);

        Console.Clear();

        // Reading Through the List
        foreach (Activity _activity in activity)
        {
            _activity.GetSummary();
            Console.WriteLine();
            Thread.Sleep(500);
        }



    }
}