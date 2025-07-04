class Goals
{
    private List<Goal> _GoalList = new List<Goal>();

    private int _TotalPoints = 0;

    public Goals()
    {
        _TotalPoints = 0;
    }
    public void Create(string name, string description, int point, int type)
    {
        if (type == 1)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, point);
            _GoalList.Add(eternalGoal);
        }
        else
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, point);
            _GoalList.Add(simpleGoal);
        }

    }
    public void Create(string name, string description, int point, int timeGoal, int bPoints)
    {
        CheckListGoal checklistGoal = new CheckListGoal(name, description, point, timeGoal, bPoints);
        _GoalList.Add(checklistGoal);
    }
    public void DisplayAll()
    {
        foreach (Goal goal in _GoalList)
        {
            int index = _GoalList.IndexOf(goal);
            Console.WriteLine($"{index}.{goal.Display()}");
        }
    }
    public void DisplayTotal()
    {
        Console.WriteLine($"Total points: {_TotalPoints}");
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        string totalfile = lines[0];
        foreach (string line in lines)
        {
            if (line != totalfile)
            {
                string[] parts = line.Split("#");
                string type = parts[0];
                if (type == "simple")
                {
                    string part1 = parts[1];
                    string part2 = parts[2];
                    string part3 = parts[3];
                    int part3int = int.Parse(part3);
                    string part4 = parts[4];
                    int part4int = int.Parse(part4);

                    SimpleGoal simpleGoal = new SimpleGoal(part1, part2, part3int, part4int);
                    _GoalList.Add(simpleGoal);

                }
                else if (type == "Eternal")
                {
                    string part1 = parts[1];
                    string part2 = parts[2];
                    string part3 = parts[3];
                    int part3int = int.Parse(part3);
                    string part4 = parts[4];
                    int part4int = int.Parse(part4);
                    string part5 = parts[5];
                    int part5int = int.Parse(part5);

                    EternalGoal eternalGoal = new EternalGoal(part1, part2, part3int, part4int, part5int);
                    _GoalList.Add(eternalGoal);
                }
                else if (type == "CheckList")
                {
                    string part1 = parts[1];
                    string part2 = parts[2];
                    string part3 = parts[3];
                    int part3int = int.Parse(part3);
                    string part4 = parts[4];
                    int part4int = int.Parse(part4);
                    string part5 = parts[5];
                    int part5int = int.Parse(part5);
                    string part6 = parts[6];
                    int part6int = int.Parse(part6);
                    string part7 = parts[7];
                    int part7int = int.Parse(part7);

                    CheckListGoal checklistgoal = new CheckListGoal(part1, part2, part3int, part4int, part5int, part6int, part7int);
                    _GoalList.Add(checklistgoal);
                }
            }
            _TotalPoints = int.Parse(totalfile);

        }
    }
    public void WriteToFile()
    {
        Console.Write("what is the name the file you want to write to?:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_TotalPoints);
            foreach (Goal goal in _GoalList)
            {
                outputFile.WriteLine(goal.Save());
            }
        }
    }
    public void RecordEvent()
    {
        Console.Clear();
        DisplayAll();
        Console.Write("Which goal would you like to record a event for?:");
        string userinput = Console.ReadLine();
        int intUserInput = int.Parse(userinput);
        Goal tempGoal = _GoalList[intUserInput];
        int pointGain = tempGoal.RecordEvent();
        _TotalPoints = _TotalPoints + pointGain;
    }
}