using FluentAssertions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using UserModule.Application.Common.Interfaces;
using UserModule.Domain.Builders;
using UserModule.Domain.Entities;
using UserModule.Infrastructure.Contexts;
using UserModule.Infrastructure.Persistence;
using Xunit;

namespace UserModule.Tests.Infrastructure.Persistence;

public class UnitOfWorkTests
{
    private readonly UserModuleContext _context;
    private readonly IUnitOfWork _unitOfWork;

    public UnitOfWorkTests()
    {
        var options = new DbContextOptionsBuilder<UserModuleContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new UserModuleContext(options);
        var sender = Substitute.For<ISender>();
        _unitOfWork = new UnitOfWork(_context, sender);
    }

     [Fact]
     public void Repository_ShouldReturnRepositoryOfCorrectType()
     {
         // Act
         var repository = _unitOfWork.Repository<User>();

         // Assert
         repository.Should().BeOfType<GenericRepository<User>>();
     }
     
     [Fact]
     public async Task SaveAsync_ShouldSaveChangesToContext()
     {
         // Arrange
         var user = UserBuilder.Create()
             .WithId(Guid.NewGuid())
             .WithLastName("Doe")
             .WithFirstName("John")
             .WithEmailAddress("test@test.com")
             .Build();
         _unitOfWork.Repository<User>().Create(user);

         // Act
         await _unitOfWork.SaveAsync(CancellationToken.None);

         // Assert
         _context.Users.Should().Contain(user);
     }
     
     [Fact]
     public void Rollback_ShouldUndoChangesInContext()
     {
         // Arrange
         var user = UserBuilder.Create()
             .WithId(Guid.NewGuid())
             .WithLastName("Doe")
             .WithFirstName("John")
             .WithEmailAddress("test@test.com")
             .Build();
         _unitOfWork.Repository<User>().Create(user);

         // Act
         _unitOfWork.Rollback();

         // Assert
         _context.Users.Should().NotContain(user);
     }
}