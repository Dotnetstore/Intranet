namespace Utilities.Entities;

public abstract class Person : BaseAuditableEntity
{
    public required string LastName { get; set; }

    public required string FirstName { get; set; }

    public required string EmailAddress { get; set; }
}