namespace Domain;

using Framework.Entities;

public class Ingredient : EntityBase
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}