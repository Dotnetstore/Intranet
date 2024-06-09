using FluentAssertions;
using Utilities.Entities;
using Xunit;

namespace Utilities.Tests.Entities;

public class PersonTests
{
    private readonly TestClassForPerson _person = new()
    {
        LastName = "Doe",
        FirstName = "John",
        EmailAddress = "test@test.com"
    };

    [Fact]
    public void LastName_ShouldReturnCorrectValue()
    {
        // Assert
        _person.LastName.Should().Be("Doe");
    }

    [Fact]
    public void FirstName_ShouldReturnCorrectValue()
    {
        // Assert
        _person.FirstName.Should().Be("John");
    }

    [Fact]
    public void EmailAddress_ShouldReturnCorrectValue()
    {
        // Assert
        _person.EmailAddress.Should().Be("test@test.com");
    }
}

internal class TestClassForPerson : Person;