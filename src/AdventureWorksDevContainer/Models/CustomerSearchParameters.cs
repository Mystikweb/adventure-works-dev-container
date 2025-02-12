namespace AdventureWorksDevContainer.Models;

/// <summary>
/// Represents the search parameters for the customer search.
/// </summary>
public sealed record CustomerSearchParameters
{
    /// <summary>
    /// AddressType to search for.
    /// <para>Possible values are 'Home' or 'Shipping' as this is an individual customer.</para>
    /// </summary>
    public string? AddressType { get; init; }

    /// <summary>
    /// City to search for.
    /// </summary>
    public string? City { get; init; }

    /// <summary>
    /// CountryRegionName to search for.
    /// </summary>
    public string? CountryRegionName { get; init; }

    /// <summary>
    /// Demographics to search for.
    /// </summary>
    public string? Demographics { get; init; }

    /// <summary>
    /// EmailAddress to search for.
    /// </summary>
    public string? EmailAddress { get; init; }

    /// <summary>
    /// FirstName to search for.
    /// </summary>
    public string? FirstName { get; init; }

    /// <summary>
    /// LastName to search for.
    /// </summary>
    public string? LastName { get; init; }

    /// <summary>
    /// PhoneNumber to search for.
    /// </summary>
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// PhoneNumberType to search for.
    /// <para>Possible values are 'Cell' or 'Home' as this is an individual customer.</para>    
    /// </summary>
    public string? PhoneNumberType { get; init; }

    /// <summary>
    /// PostalCode to search for.
    /// </summary>
    public string? PostalCode { get; init; }

    /// <summary>
    /// StateProvinceName to search for.
    /// </summary>
    public string? StateProvinceName { get; init; }
    
    /// <summary>
    /// The maximum number of records to return.
    /// <para>Defaults to 100.</para>
    /// </summary>
    public int MaxRecords { get; init; } = 100;
}
