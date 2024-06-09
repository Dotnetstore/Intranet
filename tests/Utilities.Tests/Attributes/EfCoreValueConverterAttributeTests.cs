using FluentAssertions;
using Utilities.Attributes;
using Xunit;

namespace Utilities.Tests.Attributes;

public class EfCoreValueConverterAttributeTests
{
    [Fact]
    public void ValueConverter_ShouldReturnCorrectType()
    {
        // Arrange
        var type = typeof(string);
        var attribute = new EfCoreValueConverterAttribute(type);

        // Act
        var result = attribute.ValueConverter;

        // Assert
        result.Should().Be(type);
    }
}