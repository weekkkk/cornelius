

namespace Cornelius.Project.Models;

public class Image: BaseEntity
{
    public Image(string name, byte[] dataImage, Project project)
    {
        Name = name;
        DataImage = dataImage;
        Project = project;
    }

    private Image()
    {
    }

    public string Name { get; set; }
    public byte[] DataImage { get; set; }
    public Project Project { get; set; }
}