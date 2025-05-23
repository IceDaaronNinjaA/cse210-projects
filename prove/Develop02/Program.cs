using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal1 = new Journal();
        string userInput = "none";
        int menuInput = 5;
        Console.WriteLine("Welcome to Journal Keeper");
        do
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. write a new entry");
            Console.WriteLine("2. display cerain journal");
            Console.WriteLine("3. load journal past");
            Console.WriteLine("4. save cerain journal");
            Console.WriteLine("5. quit out of this program");
            Console.Write("What would you like to do?");
            userInput = Console.ReadLine();
            menuInput = int.Parse(userInput);
            if (menuInput == 1)
            {

            }
            else if (menuInput == 2)
            {

            }
            else if (menuInput == 3)
            {

            }
            else if (menuInput == 4)
            {

            }
            else
            {
                Console.WriteLine("This program has ended.");
            }


        }
        while (menuInput != 5);
    }
}