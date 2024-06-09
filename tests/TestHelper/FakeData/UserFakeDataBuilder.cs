using UserModule.Domain.Builders;
using UserModule.Infrastructure.Contexts;

namespace TestHelper.FakeData;

public static class UserFakeDataBuilder
{
    public static Guid UserId => Guid.Parse("A8A6EC30-A117-4B6D-ABD2-A903CC0F72B4");

    public static void Generate(UserModuleContext context)
    {
        context.Users.Add(
            UserBuilder.Create()
                .WithId(UserId)
                .WithLastName("Doe")
                .WithFirstName("John")
                .WithEmailAddress("test@test.com")
                .Build());
        
        context.SaveChanges();
    }
}