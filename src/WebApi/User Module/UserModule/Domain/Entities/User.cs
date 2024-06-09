using UserModule.Domain.StronglyTypedIds;
using Utilities.Entities;

namespace UserModule.Domain.Entities;

public class User : Identity
{
    public UserId Id { get; init; }
}