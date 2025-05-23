using System;
using System.IO.Pipes;


class Program
{
    static void Main(string[] args)
    {
        
        // Console.WriteLine("Hello World!");

        // Console.WriteLine("Hey how are you?");

        // for(int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine("Hello Dilan");
        // }
        Circle myCircle = new Circle(10);

        Cylinder myCylinder = new Cylinder();

            // myCircle.SetRadius(10);

            myCylinder.SetHeight(10);
            myCylinder.SetCircle(myCircle);

        Console.WriteLine($"{myCircle.GetRadius()}");

        Console.WriteLine($"{myCircle.GetArea()}");

        Console.WriteLine($"{myCylinder.GetVolume()}");


        
    }
}
