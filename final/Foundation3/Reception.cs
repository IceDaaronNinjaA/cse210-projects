class Reception : Event
{
    

    private string _email;

    public Reception( string email, string title, string description, string date, int time, string address) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return $"Recepton {base.FullDetails()} RSP at: {_email}";
    }

    public override string ShortDetails()
    {
        return $"Recepton {base.ShortDetails()}";
    }
}