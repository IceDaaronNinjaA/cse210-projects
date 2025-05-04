using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string inputUser = "void";
        int numberFromUser = 0;
        List<int> numbers;
        numbers = new List<int>();
        do{
        Console.Write("add a number for the list: ");
        inputUser = Console.ReadLine();
        numberFromUser = int.Parse(inputUser);
        if (numberFromUser != 0)
        {
            numbers.Add(numberFromUser);
        }
        }
        while (numberFromUser != 0);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}