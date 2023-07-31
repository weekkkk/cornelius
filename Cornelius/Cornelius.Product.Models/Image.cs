namespace Cornelius.Product.Models;

public class Image: BaseEntity
{
    public string Name { get; set; }
    public byte[] DataImage { get; set; }
    public Product Product { get; set; }
}