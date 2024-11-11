class Entry
{
    private string _prompt;
    private string _response;
    private string _location;
    private DateTime _date;

    public Entry(string prompt, string response, string location)
    {
        _prompt = prompt;
        _response = response;
        _location = location;
        _date = DateTime.Now;
    }

    public string GetPrompt() => _prompt;
    public string GetResponse() => _response;
    public string GetLocation() => _location;
    public DateTime GetDate() => _date;

    public override string ToString()
    {
        return $"{_prompt}|{_response}|{_location}|{_date:yyyy-MM-dd HH:mm:ss}";
    }
    public static Entry FromString(string entryString)
    {
        var parts = entryString.Split('|');
        if (parts.Length != 4)
        {
            return null;
        }

        string prompt = parts[0];
        string response = parts[1];
        string location = parts[2];
    
        if (!DateTime.TryParseExact(parts[3], "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime date)) 
        {
            return null;
        }

        return new Entry(prompt, response, location) { _date = date };
    }
}