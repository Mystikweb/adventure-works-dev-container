using AdventureWorksDevContainer.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AdventureWorksDevContainer.Data.Services;

/// <inheritdoc cref="ICustomerRepository"/>
public sealed class CustomerRepository(ILogger<CustomerRepository> logger,
    IMapper mapper,
    AdventureWorks2022Context context) : ICustomerRepository
{
    public Task<CustomerViewModel> AddAsync(CustomerViewModel entity, CancellationToken cancellationToken = default)
    {
        logger.LogWarning("{Method} not implemented", nameof(AddAsync));
        return Task.FromResult(entity);
    }

    public async Task<CustomerViewModel> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        logger.LogWarning("{Method} not implemented", nameof(DeleteAsync));

        var customer = await context.VIndividualCustomers.FindAsync([id], cancellationToken) ??
            throw new KeyNotFoundException($"Customer with ID {id} not found.");

        return mapper.Map<CustomerViewModel>(customer);
    }

    public async Task<IEnumerable<CustomerViewModel>> GetAllAsync(CancellationToken cancellationToken = default) 
    {
        var customers = await context.VIndividualCustomers.AsNoTracking().ToListAsync(cancellationToken);
        return [.. customers.Select(c => mapper.Map<CustomerViewModel>(c))];
    }

    public async Task<CustomerViewModel?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var customer = await context.VIndividualCustomers.FindAsync([id], cancellationToken);
        return mapper.Map<CustomerViewModel?>(customer);
    }

    public async Task<CustomerViewModel?> GetByNameAsync(string firstName, string lastName, CancellationToken cancellationToken = default)
    {
        var customer = await context.VIndividualCustomers
            .Where(c => c.FirstName == firstName && c.LastName == lastName)
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

        return mapper.Map<CustomerViewModel?>(customer);
    }

    public async Task<IEnumerable<CustomerViewModel>> SearchAsync(CustomerSearchParameters searchParameters, CancellationToken cancellationToken = default)
    {
        var query = context.VIndividualCustomers.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchParameters.AddressType))
            query = query.Where(c => c.AddressType == searchParameters.AddressType);

        if (!string.IsNullOrWhiteSpace(searchParameters.City))
            query = query.Where(c => c.City == searchParameters.City);

        if (!string.IsNullOrWhiteSpace(searchParameters.CountryRegionName)) 
            query = query.Where(c => c.CountryRegionName == searchParameters.CountryRegionName);

        if (!string.IsNullOrWhiteSpace(searchParameters.Demographics))
            query = query.Where(c => c.Demographics == searchParameters.Demographics);

        if (!string.IsNullOrWhiteSpace(searchParameters.EmailAddress))
            query = query.Where(c => c.EmailAddress == searchParameters.EmailAddress);

        if (!string.IsNullOrWhiteSpace(searchParameters.FirstName))
            query = query.Where(c => c.FirstName.Contains(searchParameters.FirstName));

        if (!string.IsNullOrWhiteSpace(searchParameters.LastName))
            query = query.Where(c => c.LastName.Contains(searchParameters.LastName));

        if (!string.IsNullOrWhiteSpace(searchParameters.PhoneNumber))
            query = query.Where(c => c.PhoneNumber == searchParameters.PhoneNumber);

        if (!string.IsNullOrWhiteSpace(searchParameters.PhoneNumberType))
            query = query.Where(c => c.PhoneNumberType == searchParameters.PhoneNumberType);

        if (!string.IsNullOrWhiteSpace(searchParameters.PostalCode))
            query = query.Where(c => c.PostalCode == searchParameters.PostalCode);

        if (!string.IsNullOrWhiteSpace(searchParameters.StateProvinceName))
            query = query.Where(c => c.StateProvinceName == searchParameters.StateProvinceName);

        var customers = await query.Take(searchParameters.MaxRecords)
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        return [.. customers.Select(c => mapper.Map<CustomerViewModel>(c))];
    }

    public async Task<CustomerViewModel> UpdateAsync(CustomerViewModel entity, CancellationToken cancellationToken = default)
    {
        logger.LogWarning("{Method} not implemented", nameof(UpdateAsync));

        var customer = await context.VIndividualCustomers.FindAsync([entity.BusinessEntityId], cancellationToken) ??
            throw new KeyNotFoundException($"Customer with ID {entity.BusinessEntityId} not found.");

        return mapper.Map<CustomerViewModel>(customer);
    }

    #region IDisposable Support
    private bool _disposedValue = false; // To detect redundant calls

    private void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~CustomerRepository()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
    #endregion
}
