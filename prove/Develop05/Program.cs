using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        int end = 1;
        Goals myGoals = new Goals();
        // myGoals.Create("save the world", "I have to say the world", 2000, 1);
        // myGoals.DisplayAll();

        do
        {
            myGoals.DisplayTotal();
            Console.WriteLine("hello what would you like to do?");
            Console.WriteLine("(you can just put the number of what you would like to do)");
            Console.WriteLine("1. Display all goals");
            Console.WriteLine("2. Add a goal");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goal List from file");
            Console.WriteLine("5. Add an event of a goal");
            Console.WriteLine("6. Quit");
            string userinput = Console.ReadLine();
            int intUserInput = int.Parse(userinput);
            if (intUserInput == 1)
            {
                myGoals.DisplayAll();
            }
            else if (intUserInput == 2)
            {
                Console.WriteLine("What goal type would you like to record?");
                Console.WriteLine("1. Simple");
                Console.WriteLine("2. Eternal");
                Console.WriteLine("3. Check List");
                userinput = Console.ReadLine();
                intUserInput = int.Parse(userinput);
                if (intUserInput == 1)
                {
                    Console.Write("What is the name of the goal:");
                    string name = Console.ReadLine();
                    Console.Write("What is the descrition of the goal:");
                    string description = Console.ReadLine();
                    Console.Write("how many point do you get when you complete the goal:");
                    userinput = Console.ReadLine();
                    int point = int.Parse(userinput);
                    Console.WriteLine($"So your goal is name {name}, you have to do {description}, and it is worth {point} points.");
                    myGoals.Create(name, description, point, 1);
                    Console.WriteLine("Your goal is created!");

                }
                else if (intUserInput == 2)
                {
                    Console.Write("What is the name of the goal:");
                    string name = Console.ReadLine();
                    Console.Write("What is the descrition of the goal:");
                    string description = Console.ReadLine();
                    Console.Write("how many point do you get when you complete the goal:");
                    userinput = Console.ReadLine();
                    int point = int.Parse(userinput);
                    Console.WriteLine($"So your goal is name {name}, you have to do {description}, and it is worth {point} points.");
                    myGoals.Create(name, description, point, 2);
                    Console.WriteLine("Your goal is created!");
                }
                else if (intUserInput == 3)
                {
                    Console.Write("What is the name of the goal:");
                    string name = Console.ReadLine();
                    Console.Write("What is the descrition of the goal:");
                    string description = Console.ReadLine();
                    Console.Write("how many point do you get when you complete the goal:");
                    userinput = Console.ReadLine();
                    int point = int.Parse(userinput);
                    Console.Write("how many time are you aiming for:");
                    userinput = Console.ReadLine();
                    int timeGoal = int.Parse(userinput);
                    Console.Write("when you reach that goal how many points do you want to gain:");
                    userinput = Console.ReadLine();
                    int bPoints = int.Parse(userinput);
                    Console.WriteLine($"So your goal is name {name}, you have to do {description}, and it is worth {point} points.");
                    Console.WriteLine($"You are aiming for {timeGoal} times and you will get {bPoints} points when you reach that.");
                    myGoals.Create(name, description, point, timeGoal, bPoints);
                    Console.WriteLine("Your goal is created!");
                }
            }
            else if (intUserInput == 3)
            {
                myGoals.WriteToFile();
            }
            else if (intUserInput == 4)
            {
                Console.Write("What is the name of the file you want load from:");
                string filename = Console.ReadLine();
                myGoals.ReadFromFile(filename);
            }
            else if (intUserInput == 5)
            {
                myGoals.RecordEvent();
            }
            else if (intUserInput == 6)
            {
                end = 0;
            }
            Thread.Sleep(30000);
            Console.Clear();
        }
        while (end == 1);





    }
}