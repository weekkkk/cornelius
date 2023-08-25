using Cornelius.Product.Models;
using Cornelius.Product.Services.Exception;
using Cornelius.Product.Services.Providers;
using Cornelius.Product.Services.Request;
using Cornelius.Product.Services.Service;

namespace Cornelius.Product.Services;

public class ProductService: IProductService
{
    private readonly IProductProvider _productProvider;

    public ProductService(IProductProvider productProvider)
    {
        _productProvider = productProvider;
    }

    public async Task CreateAsync(ProductRequest product, CancellationToken cancellationToken)
    {
        if (await _productProvider.GetByIdAsync(product.Id, cancellationToken).ConfigureAwait(false) != null)
            throw new ExistIsEntityException("Такой продукт существует");
        var productDb = new Models.Product(product.Name, product.Description, new List<Image>());
        productDb.Images.AddRange(ConvertImageInArrayByte(product.Images, productDb));
        await _productProvider.AddAsync(productDb, cancellationToken);
    }

    

    public async Task<Models.Product> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var product = await _productProvider.GetByIdAsync(id, cancellationToken);
        if (product == null)
            throw new NotExistException("Такого товара не существует");
        return product;

    }

    public async Task<List<Models.Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _productProvider.GetAllAsync(new CancellationToken());
    }

    public async Task UpdateAsync(ProductRequest product, CancellationToken cancellationToken)
    {
        var productDb = await GetByIdAsync(product.Id, cancellationToken);
        productDb.Name = product.Name;
        productDb.Description = product.Description;
        productDb.Images.AddRange(ConvertImageInArrayByte(product.Images, productDb));
        productDb.DateUpdate = DateTime.Now;
        await _productProvider.UpdateAsync(productDb, cancellationToken);

    }

    private List<Image> ConvertImageInArrayByte(List<ImageRequest> imagesRequests, Models.Product product)
    {
        var images = new List<Image>();
        foreach (var image in imagesRequests)
        {
            var img = new Image(image.Name, null, product);
            using (var binaryReader = new BinaryReader(image.DataImage.OpenReadStream()))
            {
                img.DataImage = binaryReader.ReadBytes((int)image.DataImage.Length);
            }
            images.Add(img);
        }
        return images;
    }
}