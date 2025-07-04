class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int point)
    : base(name, description, point) { }
    public SimpleGoal(string name, string description, int point, int complete)
    : base(name, description, point, complete) { }

    public override string Save()
    {
        return $"Simple#{base.Save()}";
    }

    public override int RecordEvent()
    {
        base.setComplete();
        return base.GetPoints();
    }
}