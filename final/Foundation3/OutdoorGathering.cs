class OutdoorGathering : Event
{
    

    private string _weather;

    public OutdoorGathering( string weather, string title, string description, string date, int time, string address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"Outdoor Gathering {base.FullDetails()} weather: {_weather}";
    }

    public override string ShortDetails()
    {
        return $"Outdoor Gathering {base.ShortDetails()}";
    }
}