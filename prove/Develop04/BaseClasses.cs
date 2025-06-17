class BaseClasses
{
    private string _name;

    private int _duration;

    private string _description;

    private DateTime _endTime;

    public BaseClasses()
    {
        _name = "void";
        _description = "void";
        _duration = 0;
    }
    public BaseClasses(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
}