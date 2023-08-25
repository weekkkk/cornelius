using Cornelius.Project.Models;
using Cornelius.Project.Services.Exception;
using Cornelius.Project.Services.Providers;
using Cornelius.Project.Services.Request;
using Cornelius.Project.Services.Service;

namespace Cornelius.Project.Services;

public class ProjectService: IProjectService
{
    private readonly IProjectProvider _projectProvider;

    public ProjectService(IProjectProvider projectProvider)
    {
        _projectProvider = projectProvider;
    }


    public async Task CreateAsync(ProjectRequest project, CancellationToken cancellationToken)
    {
        if (await _projectProvider.GetByIdAsync(project.Id, cancellationToken).ConfigureAwait(false) != null)
            throw new ExistIsEntityException("Такой проект существует");
        var projectDb = new Models.Project(project.Name, project.Description, new List<Image>());
        projectDb.Images.AddRange(ConvertImageInArrayByte(project.Images, projectDb));
        await _projectProvider.AddAsync(projectDb, cancellationToken);
    }

    

    public async Task<Models.Project> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var project = await _projectProvider.GetByIdAsync(id, cancellationToken);
        if (project == null)
            throw new NotExistException("Такого проекта не существует");
        return project;

    }

    public async Task<List<Models.Project>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _projectProvider.GetAllAsync(new CancellationToken());
    }

    public async Task UpdateAsync(ProjectRequest project, CancellationToken cancellationToken)
    {
        var projectDb = await GetByIdAsync(project.Id, cancellationToken);
        projectDb.Name = project.Name;
        projectDb.Description = project.Description;
        projectDb.Images.AddRange(ConvertImageInArrayByte(project.Images, projectDb));
        projectDb.DateUpdate = DateTime.Now;
        await _projectProvider.UpdateAsync(projectDb, cancellationToken);

    }

    private List<Image> ConvertImageInArrayByte(List<ImageRequest> imagesRequests, Models.Project project)
    {
        var images = new List<Image>();
        foreach (var image in imagesRequests)
        {
            var img = new Image(image.Name, null, project);
            using (var binaryReader = new BinaryReader(image.DataImage.OpenReadStream()))
            {
                img.DataImage = binaryReader.ReadBytes((int)image.DataImage.Length);
            }
            images.Add(img);
        }
        return images;
    }
}