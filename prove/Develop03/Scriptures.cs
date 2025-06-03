class Scriptures
{
    private Random randWords = new Random();
    private List<Word> _scripturesWords = new List<Word>();
    private List<Word> _backUpScripture = new List<Word>();
    private Reference reference = new Reference();

    private void SplitTextIntoWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (string wordInText in words)
        {
            _scripturesWords.Add(new Word(wordInText));
            _backUpScripture.Add(new Word(wordInText));
        }
        
    }

    public Scriptures()
    {
        SplitTextIntoWords("Test Statement");
        reference.setReference("test", 1, 3, 2);
    }
    public Scriptures(string book, int chapter, int startVerse, int endVerse, string text)
    {
        SplitTextIntoWords(text);
        reference.setReference(book, chapter, startVerse, endVerse);
    }
    public Scriptures(string book, int chapter, int verse, string text)
    {
        SplitTextIntoWords(text);
        reference.setReference(book, chapter, verse);
    }
    public Scriptures(string book, int chapter, string text)
    {
        SplitTextIntoWords(text);
        reference.setReference(book, chapter);
    }
    public void DisplayScripture()
    {
        DisplayScriptureboth(_scripturesWords);
    }
    public void DisplayBackUpScripture()
    {
        DisplayScriptureboth(_backUpScripture);
    }
    private void DisplayScriptureboth(List<Word> scripturesWords)
    {
        reference.displayReferance();
        foreach (Word forword in scripturesWords)
        {
            forword.desplayWord();
        }
    Console.WriteLine("");
    Console.WriteLine("");
    }
    public void removeWords()
    {
        ifAllVoid();
        int listIndex = (randWords.Next(_scripturesWords.Count));
        _scripturesWords[listIndex].SetToVoid();
        listIndex = (randWords.Next(_scripturesWords.Count));
        _scripturesWords[listIndex].SetToVoid();
        listIndex = (randWords.Next(_scripturesWords.Count));
        _scripturesWords[listIndex].SetToVoid();


    }
    private void ifAllVoid()
    {
        int countOfVoid = 0;
        foreach (Word forword in _scripturesWords)
        {
            int voidMaybe = forword.GetDisplayType();
            int numberCheck = 0;
            if (voidMaybe == numberCheck)
            {
                countOfVoid++;
            }
        }
        int countWords = _scripturesWords.Count;
        if(countWords == (countOfVoid))
        {
            Console.WriteLine("no more words to remove");
            Environment.Exit(0);
        }
    }

}