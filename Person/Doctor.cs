class Doctor : Person
{
    private string _tools;
    public Doctor(string firstName, string lastName, int Age, string tools) :
    base(firstName, lastName, Age)
    {
        _tools = tools;
    }

    public string GetPoliceManInformation()
    {
        return $"tools: {_tools} :: {GetPersonInformation()}";
    }

    public override string GetPersonInformation()
    {
        return $"I am a Doctor. Tools: {_tools} { base.GetPersonInformation()}";
    }
}