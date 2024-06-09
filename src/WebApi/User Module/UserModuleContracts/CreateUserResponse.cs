namespace UserModuleContracts;

public record struct CreateUserResponse(
    Guid Id,
    string LastName,
    string FirstName,
    string EmailAddress);