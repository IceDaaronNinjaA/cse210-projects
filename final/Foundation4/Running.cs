class Running : Activity
{
    private double _distance;

    private double _time;

    public Running(double distance, double time, string date) : base(date, "running")
    {
        _distance = distance;
        _time = time;
    }

    public override double getdistance()
    {
        return _distance;
    }

    public override double getpace()
    {
        return _time / _distance;

    }

    public override double getspeed()
    {
        return _distance / _time / 60;
    }

    public override string getSummary()
    {
        return $"{base.getSummary()} ({_time}mins) Distance: {getdistance()} km, speed: {getspeed()} kph, Pace: {getpace} min per km";
    }

    
}