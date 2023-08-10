using Microsoft.AspNetCore.Http;

namespace Cornelius.Project.Services.Request;

public class ImageRequest
{
    public string Name { get; set; }
    public IFormFile DataImage { get; set; }
}