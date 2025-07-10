
using System.Xml.Serialization;

class Program

{




    // static void TestByRef(int x, ref string n)
    // {
    //     x++;
    //     n += " plus betty";
    //     Console.WriteLine($"In TestByRef: {x} {n}");
    // }
    // static void TestByOut(out int a)
    // {
    //     a = 10101;
    //     Console.WriteLine($"In TestByout: {a}");
    // }
    static void Main(string[] args)
    {

        int? x = null;
        string? name = null;

        int y = x ?? 29;
        name ??= "bob";
        Console.WriteLine($"{y} {name}");

        
    //     Console.WriteLine("Hello World");

        //     int z = 10;

        //     string name = "bob";

        //     TestByRef(z, ref name);
        //     Console.WriteLine($"In Main: {z} {name}");

        //     int c;

        //     TestByOut(out c);

        //     Console.WriteLine($"In Main: c is: {c}");
        //     int duration = 12;
        //     DateTime currentTime = DateTime.Now;
        //     DateTime endTime = currentTime.AddSeconds(duration);
        //     int sleepTime = 250;
        //     int count = duration;
        //     string animationString = "(^_^)(-_-)";

        //     while (DateTime.Now < endTime)
        //     {
        //         Console.Write(animationString[0..5]);
        //         Thread.Sleep(sleepTime);
        //         Console.Write("\b\b\b\b\b");
        //         Console.Write(animationString[5..]);
        //         Thread.Sleep(sleepTime);
        //         Console.Write("\b\b\b\b\b");
        //     }
        //     currentTime = DateTime.Now;
        //     endTime = currentTime.AddSeconds(duration);

        //     while (DateTime.Now < endTime)
        //     {
        //         Console.Write(count--);
        //         Thread.Sleep(1000);
        //         if (count >= 10)
        //         {
        //             Console.Write("\b\b");
        //         }
        //         else
        //         {
        //             Console.Write("\b");
        //         }
        //     }
        //     currentTime = DateTime.Now;
        //     endTime = currentTime.AddSeconds(duration);


        //     while (DateTime.Now < endTime)
        //     {
        //         Console.Write("+");
        //         Thread.Sleep(sleepTime);
        //         Console.Write("\b");
        //         Console.Write("-");
        //         Thread.Sleep(sleepTime);
        //         Console.Write("\b");
        //     }
    }
    }
