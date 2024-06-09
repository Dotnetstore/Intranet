using UserModule.Domain.Entities;
using UserModule.Domain.StronglyTypedIds;

namespace UserModule.Domain.Builders;

public sealed class UserBuilder
{
    private UserId _id = new UserId(Guid.NewGuid());
    private string _lastName = string.Empty;
    private string _firstName = string.Empty;
    private string _emailAddress = string.Empty;
    
    private UserBuilder()
    {
    }
    
    public static UserBuilder Create()
    {
        return new UserBuilder();
    }
    
    public UserBuilder WithId(Guid id)
    {
        _id = new UserId(id);
        return this;
    }
    
    public UserBuilder WithId(UserId id)
    {
        _id = id;
        return this;
    }
    
    public UserBuilder WithLastName(string lastName)
    {
        _lastName = lastName;
        return this;
    }
    
    public UserBuilder WithFirstName(string firstName)
    {
        _firstName = firstName;
        return this;
    }
    
    public UserBuilder WithEmailAddress(string emailAddress)
    {
        _emailAddress = emailAddress;
        return this;
    }
    
    public User Build()
    {
        return new User
        {
            Id = _id,
            LastName = _lastName,
            FirstName = _firstName,
            EmailAddress = _emailAddress
        };
    }
}