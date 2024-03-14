class Word
{
    private string _text;
    private bool _visible;

    public Word(string text)
    {
        this._text = text;
        this._visible = true;
    }

    public string GetText()
    {
        return _text;
    }

    public bool IsVisible()
    {
        return _visible;
    }

    public void Hide()
    {
        _visible = false;
    }
}