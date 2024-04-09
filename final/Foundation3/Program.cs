using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating First Event
        string title1 = "The History of Technological Developments in the Western World";
        string description1 = "Lecture covering the developments made in the modern world";
        string dateTime1 = "Thursday July 11 2024 -- 4:00 pm ";
        string speaker = "Dr. Smart";
        int capacity = 350;
        Address Address1 = new Address();
        Address1.SetAddress("2300 S Education st", "Boise","Idaho","USA");

        Lecture Lecture1 = new Lecture();
        Lecture1.SetEvent(title1,description1,dateTime1,Address1,speaker,capacity);

        //Creating Second Event
        string title2 = "Jake and Jenny's Wedding Reception!";
        string description2 = "Come celebrate with Us!!";
        string dateTime2 = "Saturday July 13 2024 -- 6:00 pm ";
        string email = "an-email@Email.com";
        Address Address2 = new Address();
        Address2.SetAddress("2500 N Wedding Ave", "Calgary","Alberta","Canada");

        Reception Reception1 = new Reception();
        Reception1.SetEvent(title2,description2,dateTime2,Address2,email);

        //Creating Third Event
        string title3 = "Rock Concert";
        string description3 = "Rock on with Us!!";
        string dateTime3 = "Saturday September 7 2024 -- 4:30 pm ";
        string weather = "Partly Cloudy -- 72 F -- 15% precipitation";
        Address Address3 = new Address();
        Address3.SetAddress("800 E HardRock Rd", "San Fransisco","California","USA");

        Outdoor Outdoor1 = new Outdoor();
        Outdoor1.SetEvent(title3,description3,dateTime3,Address3,weather);

        //Lecture Event Messages
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Lecture1.ShortDetails();
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Lecture1.StandardDetails();
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Lecture1.FullDetails();
        Thread.Sleep(1000);

        //Reception Event Messages
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Reception1.ShortDetails();
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Reception1.StandardDetails();
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Reception1.FullDetails();
        Thread.Sleep(1000);

        //Outdoor Event Messages
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Outdoor1.ShortDetails();
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Outdoor1.StandardDetails();
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Outdoor1.FullDetails();
        Thread.Sleep(1000);

        Console.WriteLine();
        Console.WriteLine();


    }
}