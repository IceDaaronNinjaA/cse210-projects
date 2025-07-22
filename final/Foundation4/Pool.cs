class Pool : Activity
{


    private double _laps;

    private double _time;

    public Pool(int laps, double time, string date) : base(date, "Swimming")
    {
        _laps = laps;
        _time = time;
    }

    public override double getdistance()
    {
        return _laps * 50 / 1000;
    }

    public override double getpace()
    {
        return _time / (_laps * 50 / 1000);

    }

    public override double getspeed()
    {
        return 60 / (_time / (_laps * 50 / 1000));
    }

    public override string getSummary()
    {
        return $"{base.getSummary()} ({_time}mins) Distance: {getdistance()} km, speed: {getspeed()} kph, Pace: {getpace} min per km";
    }

    
}
