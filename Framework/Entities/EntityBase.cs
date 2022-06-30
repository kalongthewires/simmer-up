namespace Framework.Entities;

public class EntityBase
{
    public long Id { get; set; }
    public Guid Guid { get; set; }
    public DateTime DbCreateTimestamp { get; set; }
    public DateTime DbLastModifiedTimestamp { get; set; }
}