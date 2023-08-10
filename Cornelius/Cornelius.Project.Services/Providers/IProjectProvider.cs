namespace Cornelius.Project.Services.Providers;

public interface IProjectProvider
{
    Task<Models.Project> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<List<Models.Project>> GetAllAsync(CancellationToken cancellationToken);
    Task AddAsync(Models.Project project, CancellationToken cancellationToken);
    Task UpdateAsync(Models.Project project, CancellationToken cancellationToken);
}