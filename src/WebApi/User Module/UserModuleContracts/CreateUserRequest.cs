namespace UserModuleContracts;

public record struct CreateUserRequest(
    string LastName,
    string FirstName,
    string EmailAddress);