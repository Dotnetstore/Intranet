using CarModule.Application.Common.Interfaces;
using CarModule.Infrastructure.Contexts;
using CarModule.Infrastructure.Extensions;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using Xunit;

namespace CarModule.Infrastructure.Tests.Extensions;

public class AddCarModuleInfrastructureTests
{
    private readonly IServiceCollection _services = new ServiceCollection();
    private readonly IConfigurationManager _configurationManager = Substitute.For<IConfigurationManager>();

    [Fact]
    public void AddCarModuleInfrastructure_AddsServicesCorrectly()
    {
        const string connectionString = "TestConnectionString";
        _configurationManager.GetConnectionString("CarModuleConnectionString").Returns(connectionString);

        var result = _services.AddCarModuleInfrastructure(_configurationManager);

        _configurationManager.Received(2).GetConnectionString("CarModuleConnectionString");
        result.Should().BeEquivalentTo(_services);
        result.Should().Contain(x => x.ServiceType == typeof(CarModuleContext));
        result.Should().Contain(x => x.ServiceType == typeof(IGenericRepository<>));
        result.Should().Contain(x => x.ServiceType == typeof(IUnitOfWork));
    }
}