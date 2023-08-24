using Cornelius.Product.Services.Providers;
using Microsoft.EntityFrameworkCore;

namespace Cornelius.Product.Providers.Providers;

public class ProductProvider: IProductProvider
{
    private readonly ProductContext _productContext;

    public ProductProvider(ProductContext productContext)
    {
        _productContext = productContext;
    }

    public async Task<Models.Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var product = await _productContext.Products
            .Include(p => p.Images)
            .FirstOrDefaultAsync(d => d.Id == id, cancellationToken: cancellationToken).ConfigureAwait(false);
        return product;

    }

    public async Task<List<Models.Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _productContext.Products
            .Include(p => p.Images)
            .ToListAsync(cancellationToken: cancellationToken);

    }

    public async Task AddAsync(Models.Product product, CancellationToken cancellationToken)
    {
        _productContext.Add(product);
        await _productContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task UpdateAsync(Models.Product product, CancellationToken cancellationToken)
    {
        _productContext.Update(product);
        await _productContext.SaveChangesAsync(cancellationToken);
    }
}