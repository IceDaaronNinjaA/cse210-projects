using System.ComponentModel;
using System.Reflection;

class Event
{
    private string _Title;

    private string _description;

    private string _date;

    private int _time;

    private string _Address;

    public Event(string title, string description, string date, int time, string address)
    {
        _Title = title;
        _description = description;
        _date = date;
        _time = time;
        _Address = address;
    }

    public string standardDetails()
    {
        return $"{_Title} : {_description} {_date} {_time} at {_Address}";
    }

    public virtual string FullDetails()
    {
        return $"{_Title} : {_description} on {_date} at {_time} at {_Address}";
    }
    public virtual string ShortDetails()
    {
        return $" {_Title} on {_date}";
    }
}