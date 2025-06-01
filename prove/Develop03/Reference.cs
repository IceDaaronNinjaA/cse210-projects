class Reference
{
    private string _book;
    
    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public Reference()
    {
        _book = "void";
        _chapter = 0;
        _startVerse = 0;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public void setReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = 1;
        _endVerse = 0;
    }
    public void setReference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = 1;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int Verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = Verse;
        _endVerse = 0;
    }
    public void setReference(string book, int chapter, int Verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = Verse;
        _endVerse = 0;
    }
    public void displayReferance()
    {
        if(_endVerse != 0)
        {
            Console.WriteLine($"{_book}: {_chapter} {_startVerse} {_endVerse}");
        }
        else if (_startVerse!=0)
        {
            Console.WriteLine($"{_book}: {_chapter} {_startVerse}");
        }
        else
        {
            Console.WriteLine($"{_book}: {_chapter}");
        }
    }

}