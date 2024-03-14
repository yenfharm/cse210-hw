class ScriptureReference
{
    private string _book;
    private int _startV;
    private int _endV;

    public ScriptureReference(string reference)
    {
        string[] parts = reference.Split(' ');
        _book = parts[0];
        string[] verses = parts[1].Split(':');
        _startV = int.Parse(verses[1]);
        if (verses[2].Contains('-'))
        {
            string[] endVParts = verses[2].Split('-');
            _endV = int.Parse(endVParts[1]);
        }
        else
        {
            _endV = _startV;
        }
    }

    public override string ToString()
    {
        return $"{_book} {_startV}:{_endV}";
    }
}