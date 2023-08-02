namespace Cornelius.Product.Models;

public class Product:BaseEntity
{
    public Product(string name, string description, List<Image> images)
    {
        Name = name;
        Description = description;
        Images = new List<Image>();
        if (images.Count >0)
        {
            Images.AddRange(images);
        }
    }

    private Product()
    {
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public List<Image> Images { get; set; }
}