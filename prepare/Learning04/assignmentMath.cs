class AssignmentMath : Assignment
{
    private string _textbook;
    private string _problems;

    public AssignmentMath(string name, string topic, string textbook, string problems) : base(name, topic)
    {
        _textbook = textbook;
        _problems = problems;
    }

    public string GetMathSummary()
    {
        return $"{GetSummery()} {Environment.NewLine} {_textbook} - {_problems}";
    }
}