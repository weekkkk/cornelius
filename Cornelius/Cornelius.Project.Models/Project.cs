

namespace Cornelius.Project.Models;

public class Project:BaseEntity
{
    public Project(string name, string description, List<Image> images)
    {
        Name = name;
        Description = description;
        Images = new List<Image>();
        if (images.Count >0)
        {
            Images.AddRange(images);
        }
    }

    private Project()
    {
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public List<Image> Images { get; set; }
}