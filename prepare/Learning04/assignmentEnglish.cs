class AssignmentEnglish : Assignment
{
    private string _book;

    public AssignmentEnglish(string name, string topic, string book) : base(name, topic)
    {
        _book = book;
        
    }

    public string GetEnglishSummary()
    {
        return $"{GetSummery()} {Environment.NewLine} {_book} by {GetStudent()}";
    }
}