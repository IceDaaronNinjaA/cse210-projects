using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int classGrade;
        string passing;
        string letter;
        Console.Write("Please put your number grade: ");
        string userInput = Console.ReadLine();
        classGrade = int.Parse(userInput);
        if( classGrade >= 90 )
        {
         letter = "A";
         passing = "pass";
        } 
        else if( classGrade >= 80  )
        {
          letter = "B";   
          passing = "pass";
        }
        else if( classGrade >= 70  )
        {
          letter = "C";   
          passing = "pass";
        }
        else if( classGrade >= 60  )
        {
          letter = "D";   
          passing = "fail";
        }
        else 
        {
           letter = "F";
           passing = "fail";  
        }
        Console.WriteLine($"As it stands you have an {letter}.");
        Console.WriteLine($"With an {letter} you will {passing} the class.");
        if (passing == "pass")
        {
            Console.WriteLine("Great Job!");
        }
        else 
        {
            Console.WriteLine("I would check with you teacher to see if there is anything else you can do.");
        }
    }
}