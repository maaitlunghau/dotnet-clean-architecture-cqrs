namespace CLEAN.CQRS.DOMAIN.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
