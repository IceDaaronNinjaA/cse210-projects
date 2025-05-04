using System;

class Program
{
    static string Guess(int guess, int magicNumber )
    {
        if (guess == magicNumber) 
        {
            return "Your guess is Right on";
        }
        else if (guess > magicNumber)
        {
            return "Your guess is higher";
        } 
        else 
        {
            return "Your guess is lower";
        }

    }   
    static void Main(string[] args)
    {   
        string userInput = "void";
        int magicNumber = 0;
        //string magicNumberString = "void";
        int guessNumber = 1;
        string guessOutcome = "void";
        Random randomGenerator = new Random();
        //Console.Write("Give a magic number: ");
        //magicNumberString = Console.ReadLine();
        magicNumber = randomGenerator.Next(1, 100);
        //int.Parse(magicNumberString);
        do
        {
            Console.Write("What is your guess? : ");
            userInput = Console.ReadLine();
            guessNumber = int.Parse(userInput);
            guessOutcome = Guess(guess:guessNumber, magicNumber: magicNumber);
            Console.WriteLine(guessOutcome);
        }while (guessOutcome != "Your guess is Right on" );
    }
}