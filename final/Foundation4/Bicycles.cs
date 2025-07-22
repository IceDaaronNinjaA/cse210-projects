class Bicycles : Activity

{
    private double _speed;

    private double _time;


    public Bicycles(double speed, double time, string date) : base(date, "Cycling")
    {
        _speed = speed;
        _time = time;
    }

    public override double getdistance()
    {
        return _speed / 60 * _time;
    }

    public override double getpace()
    {
        return 60 /_speed;

    }

    public override double getspeed()
    {
        return _speed;
    }
    
    public override string getSummary()
    {
        return $"{base.getSummary()} ({_time}mins) Distance: {getdistance()} km, speed: {getspeed()} kph, Pace: {getpace} min per km";
    }

    
}
