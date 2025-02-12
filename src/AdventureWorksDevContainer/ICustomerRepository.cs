using AdventureWorksDevContainer.Models;

namespace AdventureWorksDevContainer;

/// <summary>
/// Repository interface for the <see cref="CustomerViewModel"/> model.
/// </summary>
/// <inheritdoc cref="IRepositoryBase{T}"/>
public interface ICustomerRepository : IRepositoryBase<CustomerViewModel>
{
    /// <summary>
    /// Retrieves a <see cref="CustomerViewModel"/> by first and last name asynchronously.
    /// </summary>
    /// <param name="firstName">The customer first name.</param>
    /// <param name="lastName">The customer last name.</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> that is used.</param>
    /// <returns>The instance of <see cref="CustomerViewModel"/> found or <see cref="null"/></returns>
    Task<CustomerViewModel?> GetByNameAsync(string firstName, string lastName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Searches for <see cref="CustomerViewModel"/> instances asynchronously.
    /// </summary>
    /// <param name="searchParameters">The <see cref="CustomerSearchParameters"/> to use for filtering.</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> that is used.</param>
    /// <returns>A collection of <see cref="CustomerViewModel"/> instances.</returns>
    Task<IEnumerable<CustomerViewModel>> SearchAsync(CustomerSearchParameters searchParameters, CancellationToken cancellationToken = default);
}
