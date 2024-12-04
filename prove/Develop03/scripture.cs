class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _text;
    private List<int> _hiddenWords;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _text = new List<Word>();
        int counter = 0;
        string[] newWords = text.Split();
        foreach (string word in newWords)
        {
            _text.Add(new Word(counter, word));
            counter += 1;
        }
        _hiddenWords = new List<int>();
    }

    public Scripture(ScriptureReference reference, string[] verses)
        : this(reference, string.Join("\n", verses))
    {
    }

    public string GetText()
    {
        string scriptureRet = "";
        foreach (Word holder in _text)
        {
            string c = holder.GetText();
            scriptureRet = scriptureRet + " " + c;
        }
        return scriptureRet;
    }
    public string GetTextHidden()
    {
        string scriptureRet = "";
        foreach (Word holder in _text)
        {
            string c = holder.GetText();
            int i = holder.GetIndex();
            if (_hiddenWords.Contains(i))
            {
                c = "_";
            }
            scriptureRet = scriptureRet + " " + c;
        }
        return scriptureRet;
    }
    public string GetScriptureReference()
        {
                return _reference.ToString();
        }
    
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_text.Count);
            while (_hiddenWords.Contains(index))
            {
                index = random.Next(_text.Count);
            }
            _hiddenWords.Add(index);
        }
    }

    public bool IsCompletelyHidden() 
    {
         return _hiddenWords.Count == _text.Count;
    }
}

// we made the attributes private instead of public properties,
// made the reference to Scripturereference intead of string
// changed string to List(Word)
// in the constructor the int counter becomes the index of each word object in the list
// GetText and GetTextHidden were made to place in the text of the verse and GTH to place the underscores in the scripture
// IsCompletlyHidden changed to a return statement