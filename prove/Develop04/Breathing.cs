public class Breathing:Activity
{

    public Breathing()
    {     
    }

    public void DisplayActivity()
    {
        Console.Clear();
        Console.Write("Get ready...  ");
        Pause();
        Console.WriteLine("");
        Console.WriteLine("");
        
        float _numberLoops = _duration / 5;

        for(int i = 0; i < _numberLoops; i++)
        {
            Console.Write("Breath in...  ");
            Pause();
            Console.WriteLine("");

            Console.Write("Breath out...");
            Pause();
            Console.WriteLine("");

            Console.WriteLine("");

        }

        Console.WriteLine("Well Done!");
        Thread.Sleep(1500);
        Console.Clear();
    }

}