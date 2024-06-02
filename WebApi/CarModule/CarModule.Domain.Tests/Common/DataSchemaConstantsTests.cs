namespace CarModule.Domain.Tests.Common;

public class DataSchemaConstantsTests
{
    [Fact]
    public void Default_Name_Length_Is100()
    {
        DataSchemaConstants.Default_Name_Length.Should().Be(100);
    }
}