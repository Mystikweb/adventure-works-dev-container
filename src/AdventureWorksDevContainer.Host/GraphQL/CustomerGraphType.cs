using AdventureWorksDevContainer.Models;
using GraphQL.Types;

namespace AdventureWorksDevContainer.Host.GraphQL;

public sealed class CustomerGraphType : ObjectGraphType<CustomerViewModel>
{
    public CustomerGraphType()
    {
        Field(c => c.AddressLine1).Description("The first line of the customer's address");
        Field(c => c.AddressLine2).Description("The second line of the customer's address");
        Field(c => c.AddressType).Description("The type of address");
        Field(c => c.BusinessEntityId).Description("The business entity ID");
        Field(c => c.City).Description("The city where the customer lives");
        Field(c => c.CountryRegionName).Description("The country or region name");
        Field(c => c.Demographics).Description("The customer's demographics");
        Field(c => c.EmailAddress).Description("The customer's email address");
        Field(c => c.FirstName).Description("The customer's first name");
        Field(c => c.LastName).Description("The customer's last name");
        Field(c => c.MiddleName).Description("The customer's middle name");
        Field(c => c.PhoneNumber).Description("The customer's phone number");
        Field(c => c.PhoneNumberType).Description("The type of phone number");
        Field(c => c.PostalCode).Description("The customer's postal code");
        Field(c => c.StateProvinceName).Description("The state or province name");
        Field(c => c.Suffix).Description("The customer's suffix");
        Field(c => c.Title).Description("The customer's title");
    }
}
