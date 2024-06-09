using FluentAssertions;
using FluentAssertions.Execution;
using UserModule.Domain.Builders;
using UserModule.Domain.StronglyTypedIds;
using Xunit;

namespace UserModule.Tests.Domain.Builders;

public class UserBuilderTests
{
    [Fact]
    public void Build_ShouldCreateUser_WithCorrectProperties()
    {
        // Arrange
        var id = new UserId(Guid.NewGuid());
        const string lastName = "Doe";
        const string firstName = "John";
        const string emailAddress = "john.doe@test.com";

        // Act
        var user = UserBuilder.Create()
            .WithId(id)
            .WithLastName(lastName)
            .WithFirstName(firstName)
            .WithEmailAddress(emailAddress)
            .Build();

        // Assert
        using (new AssertionScope())
        {
            user.Id.Should().Be(id);
            user.LastName.Should().Be(lastName);
            user.FirstName.Should().Be(firstName);
            user.EmailAddress.Should().Be(emailAddress);
        }
    }
}