using Cornelius.Product.Services.Request;

namespace Cornelius.Product.Services.Service;

public interface IProductService
{
    Task CreateAsync(ProductRequest product, CancellationToken cancellationToken);
    Task<Models.Product> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<List<Models.Product>> GetAllAsync(CancellationToken cancellationToken);
    Task UpdateAsync(ProductRequest product, CancellationToken cancellationToken);
}