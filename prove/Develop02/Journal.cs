class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
    
     public void ReadFromFile(string filename)
    {
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string line in lines)
        {
        string[] parts = line.Split("#");
        string date = parts[0];
        string question = parts[1];
        string entryText = parts[2];
        JournalEntry entry = new JournalEntry();
        entry.CreateEntryWithData(date, question, entryText);    
        this.AddEntry(entry);
        }
    }
    public void AddEntry(JournalEntry entry)
    {

    }
}