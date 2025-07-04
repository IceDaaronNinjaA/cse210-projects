class EternalGoal : Goal
{
    private int _times;
    public EternalGoal(string name, string description, int point)
    : base(name, description, point) { }
    public EternalGoal(string name, string description, int point, int complete, int times)
    : base(name, description, point, complete)
    {
        _times = times;
    }

    public override string Save()
    {
        return $"Eternal#{base.Save()}#{_times}";
    }
    public override string Display()
    {
        return $"{ base.Display()} Times Done: {_times}";
    }

    public override int RecordEvent()
    {
        _times++;
        base.setComplete();
        return base.GetPoints();
    }
}