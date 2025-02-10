using AdventureWorksDevContainer;
using AdventureWorksDevContainer.Data;
using AdventureWorksDevContainer.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Hosting;

public static class HostingExtensions
{
    public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AdventureWorks2022Context>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Application"), configure =>
                configure.UseNetTopologySuite()
                    .UseHierarchyId()));

        services.AddAutoMapper(typeof(HostingExtensions).Assembly);

        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}
