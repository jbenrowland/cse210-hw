class Running : Activity
{
    private double distance; 

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetMinutes()} min) - Distance: {distance} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}

