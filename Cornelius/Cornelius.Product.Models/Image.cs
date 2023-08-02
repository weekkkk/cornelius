namespace Cornelius.Product.Models;

public class Image: BaseEntity
{
    public Image(string name, byte[] dataImage, Product product)
    {
        Name = name;
        DataImage = dataImage;
        Product = product;
    }

    private Image()
    {
    }

    public string Name { get; set; }
    public byte[] DataImage { get; set; }
    public Product Product { get; set; }
}