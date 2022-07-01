
using Framework.Entities;

namespace Domain;

public class Fat : EntityBase
{
    public string? Name { get; set; }
    public List<string> AlternateNames { get; } = new();
    public int SmokePointFahrenheit { get; set; }
    public int SmokePointCelsius { get; set; }
    public string? Description { get; set; }
}