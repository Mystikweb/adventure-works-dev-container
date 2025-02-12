namespace AdventureWorksDevContainer.Models;

/// <summary>
/// Represents an individual customer result.
/// </summary>
public sealed record CustomerViewModel
{
    /// <summary>
    /// The first line of the address.
    /// </summary>
    public required string AddressLine1 { get; init; }

    /// <summary>
    /// The second line of the address.
    /// </summary>
    public string? AddressLine2 { get; init; }

    /// <summary>
    /// The type of the address.
    /// </summary>
    public required string AddressType { get; init; }

    /// <summary>
    /// The business entity ID.
    /// </summary>
    public int? BusinessEntityId { get; init; }

    /// <summary>
    /// The city of the address.
    /// </summary>
    public required string City { get; init; }

    /// <summary>
    /// The name of the country or region.
    /// </summary>
    public required string CountryRegionName { get; init; }

    /// <summary>
    /// The demographics information.
    /// </summary>
    public string? Demographics { get; init; }

    /// <summary>
    /// The email address.
    /// </summary>
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The first name of the customer.
    /// </summary>
    public required string FirstName { get; init; }

    /// <summary>
    /// The last name of the customer.
    /// </summary>
    public required string LastName { get; init; }

    /// <summary>
    /// The middle name of the customer.
    /// </summary>
    public string? MiddleName { get; init; }

    /// <summary>
    /// The phone number.
    /// </summary>
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The type of the phone number.
    /// </summary>
    public string? PhoneNumberType { get; init; }

    /// <summary>
    /// The postal code of the address.
    /// </summary>
    public required string PostalCode { get; init; }

    /// <summary>
    /// The name of the state or province.
    /// </summary>
    public required string StateProvinceName { get; init; }

    /// <summary>
    /// The suffix of the customer's name.
    /// </summary>
    public string? Suffix { get; init; }

    /// <summary>
    /// The title of the customer.
    /// </summary>
    public string? Title { get; init; }
}
