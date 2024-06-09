using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Utilities.Constants;
using Utilities.Entities;
using Utilities.EntityTypeConfigurations;
using Xunit;

namespace Utilities.Tests.EntityTypeConfigurations;

public class PersonEntityTypeConfigurationTests
{
    [Fact]
    public void Configure_ShouldSetCorrectConfigurationForPerson()
    {
        // Arrange
        var modelBuilder = new ModelBuilder(new ConventionSet());
        var personEntityTypeConfiguration = new TestClassForPersonEntityTypeConfiguration();

        // Act
        personEntityTypeConfiguration.Configure(modelBuilder.Entity<Person>());

        // Assert
        var entityType = modelBuilder.Model.FindEntityType(typeof(Person));

        var firstNameProperty = entityType!.FindProperty(nameof(Person.FirstName));
        firstNameProperty.Should().NotBeNull();
        firstNameProperty!.GetMaxLength().Should().Be(DataSchemaConstants.DefaultNameLength);
        firstNameProperty.IsNullable.Should().BeFalse();

        var lastNameProperty = entityType.FindProperty(nameof(Person.LastName));
        lastNameProperty.Should().NotBeNull();
        lastNameProperty!.GetMaxLength().Should().Be(DataSchemaConstants.DefaultNameLength);
        lastNameProperty.IsNullable.Should().BeFalse();

        var emailAddressProperty = entityType.FindProperty(nameof(Person.EmailAddress));
        emailAddressProperty.Should().NotBeNull();
        emailAddressProperty!.GetMaxLength().Should().Be(DataSchemaConstants.EmailAddressLength);
        emailAddressProperty.IsNullable.Should().BeFalse();
    }
}

internal class TestClassForPersonEntityTypeConfiguration : PersonEntityTypeConfiguration<Person>;