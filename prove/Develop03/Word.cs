using System.Dynamic;

class Word
{
    private string _word;

    private int _voidOrNot = 0;

    public Word()
    {
        _word = "test";
    }
    public Word(string imputWord)
    {
        _word = imputWord;
        _voidOrNot = 1;
    }
    public int GetDisplayType()
    {
        return _voidOrNot;
    }
    public void SetToVoid()
    {
        _word = new string('_', _word.Length);
        _voidOrNot = 0;
    }
    public void SetWord(string inputWord)
    {
        _word = inputWord;
    }
    public void desplayWord()
    {
        Console.Write($"{_word} ");
    }

}