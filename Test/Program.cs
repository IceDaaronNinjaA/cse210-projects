
class Program
{
    static void Main(string[] args)
    {
        int duration = 12;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 250;
        int count = duration;
        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }
        currentTime = DateTime.Now;
        endTime = currentTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            if (count >= 10)
            {
                Console.Write("\b\b");
            }
            else
            {
                Console.Write("\b");
            }
        }
        currentTime = DateTime.Now;
        endTime = currentTime.AddSeconds(duration);


        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }
}
