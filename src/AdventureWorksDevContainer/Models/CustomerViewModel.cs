namespace AdventureWorksDevContainer.Models;

public sealed record CustomerViewModel
{
    public required string AddressLine1 { get; init; }
    public string? AddressLine2 { get; init; }
    public required string AddressType { get; init; }
    public int? BusinessEntityId { get; init; }
    public required string City { get; init; }
    public required string CountryRegionName { get; init; }
    public string? Demographics { get; init; }
    public string? EmailAddress { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
    public string? PhoneNumber { get; init; }
    public string? PhoneNumberType { get; init; }
    public required string PostalCode { get; init; }
    public required string StateProvinceName { get; init; }
    public string? Suffix { get; init; }
    public string? Title { get; init; }
}
