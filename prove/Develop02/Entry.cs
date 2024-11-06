class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Location { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response, string location)
    {
        Prompt = prompt;
        Response = response;
        Location = location;
        Date = DateTime.Now;
    }
}