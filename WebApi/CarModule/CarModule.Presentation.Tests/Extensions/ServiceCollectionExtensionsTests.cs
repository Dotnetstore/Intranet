using CarModule.Presentation.Extensions;

namespace CarModule.Presentation.Tests.Extensions;

public class ServiceCollectionExtensionsTests
{
    private readonly IServiceCollection _services = new ServiceCollection();
    private readonly IConfigurationManager _configurationManager = Substitute.For<IConfigurationManager>();

    [Fact]
    public void AddCarModuleServices_AddsServicesCorrectly()
    {
        const string connectionString = "TestConnectionString";
        _configurationManager.GetConnectionString("CarModuleConnectionString").Returns(connectionString);

        var result = _services.AddCarModuleServices(_configurationManager);

        _configurationManager.Received(2).GetConnectionString("CarModuleConnectionString");
        result.Should().BeEquivalentTo(_services);
    }
}