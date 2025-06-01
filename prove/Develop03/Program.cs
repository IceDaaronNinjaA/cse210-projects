using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Scriptures newScriptures = new Scriptures("Nephi", 3,4, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        int loopEnd = 1;
        string userInput = "void";
        
        do{
            newScriptures.DisplayScripture();
            Console.Write("Type quit to end or hit enter to remove 3 words:");
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                loopEnd = 0;
            }
            else 
            {
                newScriptures.removeWords();
            }
        }
        while (loopEnd != 0);
    }
}