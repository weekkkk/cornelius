using Cornelius.Project.Services.Request;

namespace Cornelius.Project.Services.Service;

public interface IProjectService
{
    Task CreateAsync(ProjectRequest project, CancellationToken cancellationToken);
    Task<Models.Project> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<List<Models.Project>> GetAllAsync(CancellationToken cancellationToken);
    Task UpdateAsync(ProjectRequest project, CancellationToken cancellationToken);
}