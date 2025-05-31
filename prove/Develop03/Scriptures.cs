class Scriptures
{
    private List<Word> _scripturesWords = new List<Word>();

    private void SplitTextIntoWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (string wordInText in words)
        {
            _scripturesWords.Add(new Word(wordInText));
        }
    }

    public Scriptures()
    {
        SplitTextIntoWords("Test Statement");
    }
    public Scriptures(string text)
    {
        SplitTextIntoWords(text);
    }
    public void DisplayScripture()
    {
        foreach (Word forword in _scripturesWords)
        {
            forword.desplayWord();
        }

    }

}