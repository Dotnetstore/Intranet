using FluentAssertions;
using TestHelper.TestBases;
using UserModule.Domain.Builders;
using UserModule.Domain.Entities;
using Xunit;

namespace UserModule.Tests.Infrastructure.Persistence;

public class GenericRepositoryTests : TestBaseUserModuleContext
{
    [Fact]
    public async Task GetAllAsync_ShouldReturnAllEntities()
    {
        // await CreateAsync();
        
        // Act
        var result = await UnitOfWork.Repository<User>().GetAllAsync();
        
        // Assert
        result.Should().HaveCount(1);
    }
    
    [Fact]
    public async Task Create_ShouldAddEntityToContext()
    {
        // Arrange
        var user = UserBuilder.Create()
            .WithId(Guid.NewGuid())
            .WithLastName("Doe")
            .WithFirstName("John")
            .WithEmailAddress("test@test.com")
            .Build();
        
        // Act
        UnitOfWork.Repository<User>().Create(user);
        await UnitOfWork.SaveAsync(CancellationToken);
        
        var result = await UnitOfWork.Repository<User>().GetAllAsync();
        
        // Assert
        result.Should().HaveCount(2);
    }
    
     [Fact]
     public async Task Update_ShouldUpdateEntityInContext()
     {
         // await CreateAsync();
         
         // Arrange
         var result = await UnitOfWork.Repository<User>().GetAllAsync();
         var itemToUpdate = result.First();
         itemToUpdate.FirstName = "Jane";

         // Act
         UnitOfWork.Repository<User>().Update(itemToUpdate);
         await UnitOfWork.SaveAsync(CancellationToken);

         // Assert
         Context.Users.Should().Contain(itemToUpdate);
     }
     
     // [Fact]
     // public async Task Delete_ShouldUpdateEntityInContext()
     // {
     //     // Arrange
     //     var result = await UnitOfWork.Repository<User>().GetAllAsync();
     //     var itemToDelete = result.First();
     //
     //     // Act
     //     UnitOfWork.Repository<User>().Delete(itemToDelete);
     //     await UnitOfWork.SaveAsync(CancellationToken);
     //
     //     // Assert
     //     Context.Users.Should().NotContain(itemToDelete);
     // }
}