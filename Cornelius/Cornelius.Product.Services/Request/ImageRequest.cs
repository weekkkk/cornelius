using Microsoft.AspNetCore.Http;

namespace Cornelius.Product.Services.Request;

public class ImageRequest
{
    public string Name { get; set; }
    public IFormFile DataImage { get; set; }
}