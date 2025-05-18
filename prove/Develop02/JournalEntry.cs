class JournalEntry
{
    private string _entryQuestion;
    private string _journalEntry;

    private string _date;


    public override string ToString()
    {
        string outputString = "";
        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";
        return outputString;
    }
    public void Promyt()
    {

    }
    public void CreateEntryWithData(string date, string entrytext, string question)
    {


    }
    public void AddEntry()
    {

    }
}