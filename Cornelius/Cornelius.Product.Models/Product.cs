namespace Cornelius.Product.Models;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Image> Images { get; set; }
}