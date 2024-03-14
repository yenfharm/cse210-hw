class Scripture
{
    private string _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        this._reference = reference;
        this._text = text;
        this._words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetReference()
    {
        return _reference;
    }

    public string GetVisibleText()
    {
        return string.Join(" ", _words.Select(word => word.IsVisible() ? word.GetText() : "_"));
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => !word.IsVisible());
    }

    public void HideRandomWords(int numWords)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => word.IsVisible()).ToList();
        int numToHide = Math.Min(numWords, visibleWords.Count);

        for (int i = 0; i < numToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
}