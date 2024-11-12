namespace Doga20241112;

internal class City
{
    public string Name { get; set; }
    public string Country { get; set; }
    public double Population { get; set; }

    public City(string row)
    {
        var d = row.Split(';');
        Name = d[0];
        Country = d[1];
        Population = double.Parse(d[2]);
    }

    public override string? ToString() => $"{Name} {Country} {Population:F2}";
}
