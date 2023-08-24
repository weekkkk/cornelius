namespace Cornelius.Product.Services.Providers;

public interface IProductProvider
{
    Task<Models.Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<List<Models.Product>> GetAllAsync(CancellationToken cancellationToken);
    Task AddAsync(Models.Product product, CancellationToken cancellationToken);
    Task UpdateAsync(Models.Product product, CancellationToken cancellationToken);
}