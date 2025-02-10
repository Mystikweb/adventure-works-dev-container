using AdventureWorksDevContainer.Models;

using GraphQL;
using GraphQL.Types;

namespace AdventureWorksDevContainer.Host.GraphQL;

public sealed class AdventureWorksQuery : ObjectGraphType
{
    public AdventureWorksQuery()
    {
        Field<CustomerViewModel>("customer", true)
            .Argument<NonNullGraphType<StringGraphType>>("firstName", "The first name of the customer.")
            .Argument<NonNullGraphType<StringGraphType>>("lastName", "The last name of the customer.")
            .ResolveAsync(async context =>
            {
                using var scope = context.RequestServices?.CreateScope() ??
                    throw new InvalidOperationException("Could not create a scope.");

                using var customerRepository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>() ?? 
                    throw new InvalidOperationException("Could not get the customer repository.");

                var firstName = context.GetArgument<string>("firstName");
                var lastName = context.GetArgument<string>("lastName");

                return await customerRepository.GetByNameAsync(firstName, lastName, context.CancellationToken);
            });
    }
}
