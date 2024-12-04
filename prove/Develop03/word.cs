class Word
{
    private int _index; 
    private string _text;

    public Word(int index, string text)
    {
        _index = index;
        _text = text;
    }
    public string GetText ()
    {
        return _text;
    }
    public int GetIndex()
    {
        return _index;
    }
}

// Made both attributes private, added GetIndex for scripture.cs to get the private word date by making them public