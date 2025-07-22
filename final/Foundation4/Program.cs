using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Bicycles newActivity = new Bicycles(40, 30.5, "14 mar 2123");
        activities.Add(newActivity);
        Pool newActivity2 = new Pool(20, 10, "30 dec 3040");
        activities.Add(newActivity2);
        Running newActivity3 = new Running(400, 100, "1 Jan 2040");
        activities.Add(newActivity3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.getSummary}");
        }
    }
}