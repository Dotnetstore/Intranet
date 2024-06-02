using CarModule.Application.Common.Interfaces;
using CarModule.Domain.Builders;
using CarModule.Domain.Entities;
using CarModule.Infrastructure.Contexts;
using CarModule.Infrastructure.Persistence.Common;
using FluentAssertions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using Xunit;

namespace CarModule.Infrastructure.Tests.Persistence.Common;

public class UnitOfWorkTests
{
    private readonly CancellationToken _cancellationToken = new CancellationTokenSource().Token;
    private readonly IUnitOfWork _unitOfWork;
    private readonly DbContextOptions<CarModuleContext> _options = new DbContextOptionsBuilder<CarModuleContext>()
        .UseInMemoryDatabase(databaseName: "TestDatabase")
        .Options;
    private readonly CarMake _carMake = CarMakeBuilder
        .Create()
        .WithId(Guid.NewGuid())
        .WithName("Test Name")
        .WithCreatedDate(DateTimeOffset.Now)
        .Build();

    public UnitOfWorkTests()
    {
        var sender = Substitute.For<ISender>();
        _unitOfWork = new UnitOfWork(new CarModuleContext(_options), sender);
    }
    
     [Fact]
     public async Task SaveAsync_SavesChanges()
     {
         _unitOfWork.Repository<CarMake>().Create(_carMake);

         await _unitOfWork.SaveAsync(_cancellationToken);

         var result = await _unitOfWork.Repository<CarMake>().GetAllAsync();
         
         result.Should().Contain(_carMake);
     }
     
     [Fact]
     public async Task Rollback_RollsBackChanges()
     {
         _unitOfWork.Repository<CarMake>().Create(_carMake);

         _unitOfWork.Rollback();

         var result = await _unitOfWork.Repository<CarMake>().GetAllAsync();
         
         result.Should().NotContain(_carMake);
     }
     
     [Fact]
     public void Repository_ReturnsRepository()
     {
         var repository = _unitOfWork.Repository<CarMake>();

         repository.Should().NotBeNull();
     }
     
     [Fact]
     public void Sender_should_not_be_null()
     {
         _unitOfWork.Sender.Should().NotBeNull();
     }
     
     [Fact]
     public void Dispose_DisposesContext()
     {
         _unitOfWork.Dispose();

         _unitOfWork.Should().NotBeNull();
     }
}