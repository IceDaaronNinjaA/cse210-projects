class CheckListGoal : Goal
{
    private int _times;
    private int _goalaim;
    private int _bPoints;

    public CheckListGoal(string name, string description, int point, int goalAim, int bPoints)
    : base(name, description, point)
    {
        _goalaim = goalAim;
        _bPoints = bPoints;
    }
    public CheckListGoal(string name, string description, int point, int complete, int times, int goalAim, int bPoints)
    : base(name, description, point, complete)
    {
        _times = times;
        _goalaim = goalAim;
        _bPoints = bPoints;
    }

    public override string Save()
    {
        return $"CheckList#{base.Save()}#{_times}#{_goalaim}#{_bPoints}";
    }
    public override string Display()
    {
        return $"{ base.Display()} Goal: {_goalaim} Times Done: {_times}";
    }

    public override int RecordEvent()
    {
        _times++;
        if (_times == _goalaim)
        {
            base.setComplete();
            return base.GetPoints() + _bPoints;
        }
        else
        {
            return base.GetPoints();
        }
        
        
    }
}