class Scripture
{
    private Reference _reference;
    private Word[] _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordTexts = text.Split(' ');
        _words = new Word[wordTexts.Length];
        for (int i = 0; i < wordTexts.Length; i++)
        {
            _words[i] = new Word(wordTexts[i]);
        }
        _random = new Random();
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetText());
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        // Get all indices of words that are not yet hidden
        int[] visibleIndices = GetVisibleWordIndices();

        if (visibleIndices.Length > 0)
        {
            // Select a random index from the list of visible words
            int randomIndex = visibleIndices[_random.Next(visibleIndices.Length)];
            _words[randomIndex].Hide();
        }
    }

    private int[] GetVisibleWordIndices()
    {
        // Collect indices of words that are not hidden
        int[] visibleIndices = new int[_words.Length];
        int count = 0;
        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices[count++] = i;
            }
        }
        Array.Resize(ref visibleIndices, count); // Resize to actual count
        return visibleIndices;
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
