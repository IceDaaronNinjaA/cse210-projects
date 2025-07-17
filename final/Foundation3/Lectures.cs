class Lectures : Event
{
    private string _speaker;

    private int _capacity;

    public Lectures(string speaker, int capacity, string title, string description, string date, int time, string address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"Lectures by {_speaker} {base.FullDetails()} Capacity: {_capacity}";
    }

    public override string ShortDetails()
    {
        return $"Lectures {base.ShortDetails()}";
    }
}