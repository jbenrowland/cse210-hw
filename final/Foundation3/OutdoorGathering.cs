class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + "\n" +
               "Event Type: Outdoor Gathering\n" +
               "Weather Forecast: " + weatherForecast;
    }
}
