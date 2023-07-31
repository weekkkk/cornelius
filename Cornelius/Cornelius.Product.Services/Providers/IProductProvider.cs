namespace Cornelius.Product.Services.Providers;

public interface IProductProvider
{
    Task<Models.Product> GetProduct(Guid id, CancellationToken cancellationToken);
    Task<List<Models.Product>> GetAllProduct(CancellationToken cancellationToken);
    Task AddProduct(Models.Product product, CancellationToken cancellationToken);
    Task UpdateProduct(Models.Product product, CancellationToken cancellationToken);
}