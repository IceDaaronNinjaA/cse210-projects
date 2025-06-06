using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment programming = new Assignment("Who ThirdBase", "BaseBall Bases Tracker");
        Console.WriteLine($"{programming.GetSummery()}");
        AssignmentMath SportMath = new AssignmentMath("Who ThirdBase", "BaseBall Math", "Sports Math", "Problems bases 1-3");
        Console.WriteLine($"{SportMath.GetMathSummary()}");
        AssignmentEnglish English = new AssignmentEnglish("Who ThirdBase", "Presonal Stories", "When is a joke ended?");
        Console.WriteLine($"{English.GetEnglishSummary()}");

    }
}