class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // public ScriptureReference(string reference)
    // {
    //     string[] parts = reference.Split();
    //     _book = parts[0];
    //     _chapter = int.Parse(parts[1]);
    //     _startVerse = int.Parse(parts[2]);
    //     _endVerse = parts[3] != null ? int.Parse(parts[3]) : _startVerse;
    // }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString() 
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    } 
}

// made the starting attributes to private, 
//muted public ScriptureReference(string reference) transfaring it to program.cs,
// changed to string, when endverse is equal to startverse it only shows startverse