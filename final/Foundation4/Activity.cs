abstract class Activity
{
    private string _date;

    private string _type;


    public Activity(string date, string type)
    {
        _date = date;
        _type = type;
    }

    public abstract int getspeed();
    public abstract int getpace();
      public abstract int getdistance();
}