using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneFraction = new Fraction();
        Fraction twoFraction = new Fraction(5);
        Fraction threeFraction = new Fraction(6, 7);
        Fraction fourFraction = new Fraction(3, 4);
        Fraction fiveFraction = new Fraction(1, 3);
        
        Console.WriteLine($"{oneFraction.GetFractionString()}");
        Console.WriteLine($"{oneFraction.GetDecimalValue()}");
        Console.WriteLine($"{twoFraction.GetFractionString()}");
        Console.WriteLine($"{twoFraction.GetDecimalValue()}");
        Console.WriteLine($"{fourFraction.GetFractionString()}");
        Console.WriteLine($"{fourFraction.GetDecimalValue()}");
        Console.WriteLine($"{fiveFraction.GetFractionString()}");
        Console.WriteLine($"{fiveFraction.GetDecimalValue()}");
    }
}