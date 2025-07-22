abstract class Activity
{
    private string _date;

    private string _type;


    public Activity(string date, string type)
    {
        _date = date;
        _type = type;
    }

    public abstract double getspeed();
    public abstract double getpace();
    public abstract double getdistance();

    public virtual string getSummary()
    {
        return $"{_date} {_type}";
    }
}