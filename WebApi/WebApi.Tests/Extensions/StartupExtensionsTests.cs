using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using WebApi.Extensions;
using Xunit;

namespace WebApi.Tests.Extensions;

public class StartupExtensionsTests
{
         private readonly IServiceCollection _services = new ServiceCollection();
         private readonly IConfigurationManager _configurationManager = Substitute.For<IConfigurationManager>();

         [Fact]
         public void AddApplicationServices_AddsServicesCorrectly()
         {
             _configurationManager.GetConnectionString("CarModuleConnectionString").Returns("TestConnectionString");

             _services.AddAppServices(_configurationManager);

             _configurationManager.Received(2).GetConnectionString("CarModuleConnectionString");
         }
}