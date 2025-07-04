
abstract class Goal
{
    private string _name;

    private int _complete;

    private string _description;

    private int _point;

    public Goal(string name, string description, int point)
    {
        _name = name;
        _complete = 0;
        _description = description;
        _point = point;
    }
    public Goal(string name, string description, int point, int complete)
    {
        _name = name;
        _complete = complete;
        _description = description;
        _point = point;
    }

    public virtual string Display()
    {
        string x = " ";
        if (_complete != 0)
        {
            x = "x";
        }
        return $"[{x}] {_name}: {_description} points: {_point}";
    }
    public virtual string Save()
    {
        string outputString = "";
        outputString = $"{_name}#{_description}#{_point}#{_complete}";
        return outputString;
    }
    public abstract int RecordEvent();

    public void setComplete()
    {
        _complete = 1;

    }
    public int GetPoints()
    {
        return _point;
    }
}