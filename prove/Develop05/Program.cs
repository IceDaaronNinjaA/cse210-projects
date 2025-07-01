using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        Goals myGoals = new Goals();
        myGoals.Create("save the world", "I have to say the world", 2000);
        myGoals.DisplayAll();



    }
}