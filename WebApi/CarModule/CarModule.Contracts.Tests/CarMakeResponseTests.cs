using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace CarModule.Contracts.Tests;

public class CarMakeResponseTests
{
    [Fact]
    public void Should_contain_correct_properties()
    {
        var id = Guid.NewGuid();
        var name = "Toyota";

        var carMakeResponse = new CarMakeResponse(id, name);

        using(new AssertionScope())
        {
            carMakeResponse.Id.Should().Be(id);
            carMakeResponse.Name.Should().Be(name);
        }
    }
}