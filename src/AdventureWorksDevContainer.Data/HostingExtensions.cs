using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdventureWorksDevContainer.Data;

public static class HostingExtensions
{
    public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AdventureWorks2022Context>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Application"), configure =>
                configure.UseNetTopologySuite()
                    .UseHierarchyId()));

        // services.AddScoped<IProductRepository, ProductRepository>();
        // services.AddScoped<IPersonRepository, PersonRepository>();

        return services;
    }
}
