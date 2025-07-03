class Goals
{
    private List<Goal> _GoalList= new List<Goal>();

    private int _TotalPoints;

    public Goals()
    {
        _TotalPoints = 0;
    }
    public void Create(string name, string description, int point)
    {
        SimpleGoal simpleGoal = new SimpleGoal(name, description, point);
        _GoalList.Add(simpleGoal);
    }
    public void Create(string name, string description, int point, int bPoints, int timeGoal)
    {
        
    }
    public void DisplayAll()
    {
        foreach (Goal goal in _GoalList)
        {
            Console.WriteLine($"{goal.Display()}");
        }
    }
}