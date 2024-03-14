class ScriptureReference
{
    private string _book;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference(string reference)
    {
        string[] parts = reference.Split(' ');
        _book = parts[0];
        string[] verses = parts[1].Split(':');
        _startVerse = int.Parse(verses[1]);
        if (verses[2].Contains('-'))
        {
            string[] endVerseParts = verses[2].Split('-');
            _endVerse = int.Parse(endVerseParts[1]);
        }
        else
        {
            _endVerse = _startVerse;
        }
    }

    public override string ToString()
    {
        return $"{_book} {_startVerse}:{_endVerse}";
    }
}