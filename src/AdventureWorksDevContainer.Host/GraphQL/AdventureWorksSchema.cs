using GraphQL.Types;

namespace AdventureWorksDevContainer.Host.GraphQL;

public sealed class AdventureWorksSchema : Schema
{
    public AdventureWorksSchema(IServiceProvider serviceProvider, AdventureWorksQuery query)
        : base(serviceProvider) => Query = query;
}
