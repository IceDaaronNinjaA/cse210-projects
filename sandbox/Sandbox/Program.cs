using System;
using System.IO.Pipes;
class Circle
{
    private double _radius;
    

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine ("Error, Error. raduse must > 0");
            return;
        }
        _radius = radius;
    } 

    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

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
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");
        
    }
}
