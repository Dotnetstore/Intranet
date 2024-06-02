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

public class GenericRepositoryTests
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

    public GenericRepositoryTests()
    {
        var sender = Substitute.For<ISender>();
        _unitOfWork = new UnitOfWork(new CarModuleContext(_options), sender);
        
        _unitOfWork.Repository<CarMake>().Create(_carMake);
        _unitOfWork.SaveAsync(_cancellationToken).Wait();
    }

    [Fact]
    public async Task GetAllAsync_ReturnsAllEntities()
    {
        var result = await _unitOfWork.Repository<CarMake>().GetAllAsync();

        result.Should().Contain(_carMake);
    }
    
    [Fact]
    public async Task Create_AddsEntity()
    {
        var newCarMake = CarMakeBuilder
            .Create()
            .WithId(Guid.NewGuid())
            .WithName("Test Name 2")
            .WithCreatedDate(DateTimeOffset.Now)
            .Build();

        _unitOfWork.Repository<CarMake>().Create(newCarMake);
        await _unitOfWork.SaveAsync(_cancellationToken);
        
        var result = await _unitOfWork.Repository<CarMake>().GetAllAsync();

        result.Should().Contain(newCarMake);
    }
    
    [Fact]
    public async Task Update_UpdatesEntity()
    {
        var result = await _unitOfWork.Repository<CarMake>().Entities.FirstOrDefaultAsync(cancellationToken: _cancellationToken);
        
        result!.Name = "Updated Name";

        _unitOfWork.Repository<CarMake>().Update(result);
        await _unitOfWork.SaveAsync(_cancellationToken);

        result = await _unitOfWork.Repository<CarMake>().Entities.FirstOrDefaultAsync(cancellationToken: _cancellationToken);
        
        result!.Name.Should().Be("Updated Name");
    }
    
    [Fact]
    public async Task Delete_DeletesEntity()
    {
        var result = await _unitOfWork.Repository<CarMake>().Entities.FirstOrDefaultAsync(cancellationToken: _cancellationToken);
        
        _unitOfWork.Repository<CarMake>().Delete(result!);
        await _unitOfWork.SaveAsync(_cancellationToken);
        
        result = await _unitOfWork.Repository<CarMake>().Entities.FirstOrDefaultAsync(cancellationToken: _cancellationToken);
        
        result!.IsDeleted.Should().BeTrue();
    }
}