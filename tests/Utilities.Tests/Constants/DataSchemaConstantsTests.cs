using FluentAssertions;
using Utilities.Constants;
using Xunit;

namespace Utilities.Tests.Constants;

public class DataSchemaConstantsTests
{
    [Fact]
    public void DefaultNameLength_ShouldHaveCorrectValue()
    {
        // Assert
        DataSchemaConstants.DefaultNameLength.Should().Be(100);
    }

    [Fact]
    public void EmailAddressLength_ShouldHaveCorrectValue()
    {
        // Assert
        DataSchemaConstants.EmailAddressLength.Should().Be(255);
    }
}