class Word
{
    private string _txt;
    private bool _visible;

    public Word(string txt)
    {
        this._txt = txt;
        this._visible = true;
    }

    public string GetText()
    {
        return _txt;
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