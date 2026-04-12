using CLEAN.CQRS.DOMAIN.Common;

namespace CLEAN.CQRS.DOMAIN.Entities;

public class User : BaseEntity
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
