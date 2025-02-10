namespace AdventureWorksDevContainer;

/// <summary>
/// Generic repository interface for CRUD operations.
/// </summary>
/// <typeparam name="T">The entity class type being used within the repository.</typeparam>
public interface IRepositoryBase<T> : IDisposable
    where T : class
{
    /// <summary>
    /// Adds a new <typeparamref name="T"/> asynchronously.
    /// </summary>
    /// <param name="entity">The <typeparamref name="T"/> to be added.</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> that is used.</param>
    /// <returns>The instance of <typeparamref name="T"/> which would include a generated ID value.</returns>
    Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes an existing <typeparamref name="T"/> asynchronously.
    /// </summary>
    /// <param name="id">The ID to search.</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> that is used.</param>
    /// <returns>The instance of <typeparamref name="T"/> found that was deleted.</returns>
    Task<T> DeleteAsync(int id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves an <see cref="IEnumerable{T}"/> of all <typeparamref name="T"/> asynchronously.
    /// </summary>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> that is used.</param>
    /// <returns><see cref="IEnumerable{T}"/> list of <typeparamref name="T"/></returns>
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a <typeparamref name="T"/> by its ID asynchronously.
    /// <para>Will return <see cref="null"/> if not found.</para>
    /// </summary>
    /// <param name="id">The ID to search.</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> that is used.</param>
    /// <returns>The instance of <typeparamref name="T"/> found or <see cref="null"/></returns>
    Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing <typeparamref name="T"/> asynchronously.
    /// </summary>
    /// <param name="entity">The <typeparamref name="T"/> to be added.</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> that is used.</param>
    /// <returns>The updated instance of <typeparamref name="T"/>.</returns>
    Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
}
