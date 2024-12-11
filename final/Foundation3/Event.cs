class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return "Title: " + title + "\n" +
               "Description: " + description + "\n" +
               "Date: " + date + "\n" +
               "Time: " + time + "\n" +
               "Address: " + address.GetFullAddress();
    }

    public string GetShortDescription()
    {
        return "Event Type: " + this.GetType().Name + "\n" +
               "Title: " + title + "\n" +
               "Date: " + date;
    }
}
