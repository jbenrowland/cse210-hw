class Scripture
{
    private readonly Reference _reference;
    private readonly List<string> _words;
    private readonly HashSet<int> _hiddenWordIndices;
    private readonly Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').ToList();
        _hiddenWordIndices = new HashSet<int>();
        _random = new Random();
    }

    public void Display()
    {
        Console.WriteLine(_reference.Text);
        Console.WriteLine(string.Join(" ", _words.Select((word, index) =>
            _hiddenWordIndices.Contains(index) ? "_____" : word)));
    }

    public void HideRandomWords()
    {
        if (_hiddenWordIndices.Count < _words.Count)
        {
            int index;
            do
            {
                index = _random.Next(_words.Count);
            } while (_hiddenWordIndices.Contains(index));

            _hiddenWordIndices.Add(index);
        }
    }
}
