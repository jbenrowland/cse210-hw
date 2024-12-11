class Cycling : Activity
{
    private double speed; 
    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * GetMinutes() / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetMinutes()} min) - Distance: {GetDistance():F2} miles, Speed: {speed:F1} mph, Pace: {GetPace():F2} min per mile";
    }
}
