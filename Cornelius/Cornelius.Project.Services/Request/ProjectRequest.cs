
namespace Cornelius.Project.Services.Request;

public class ProjectRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<ImageRequest> Images { get; set; }
}