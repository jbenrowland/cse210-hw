class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + "\n" +
               "Event Type: Lecture\n" +
               "Speaker: " + speaker + "\n" +
               "Capacity: " + capacity;
    }
}
