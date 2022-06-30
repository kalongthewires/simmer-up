namespace Domain;

using Framework.Entities;

public class Fat : EntityBase
{
    public string? Name { get; set; }
    public int SmokePoint { get; set; }
    public string? Description { get; set; }
}