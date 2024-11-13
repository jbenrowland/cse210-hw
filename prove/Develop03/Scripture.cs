class Scripture
{
    private Reference _reference;
    private string[] _words;
    private bool[] _hiddenWords;
    private Random _random;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ');
        _hiddenWords = new bool[_words.Length];
        _random = new Random();
    }
    public void Display()
    {
        Console.WriteLine(_reference.GetText());
        for (int i = 0; i < _words.Length; i++)
        {
            if (_hiddenWords[i])
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(_words[i] + " ");
            }
        }
        Console.WriteLine();
    }
    public bool AllWordsHidden()
    {
        for (int i = 0; i < _hiddenWords.Length; i++)
        {
            if (!_hiddenWords[i])
            {
                return false; 
            }
        }
        return true; 
    }
    public void HideRandomWords()
    {
        bool allHidden = true;
        for (int i = 0; i < _hiddenWords.Length; i++)
        {
            if (!_hiddenWords[i])
            {
                allHidden = false;
                break;
            }
        }
        if (!allHidden)
        {
            int index;
            do
            {
                index = _random.Next(_words.Length);
            }
            while (_hiddenWords[index]);

            _hiddenWords[index] = true;
        }
    }
}
