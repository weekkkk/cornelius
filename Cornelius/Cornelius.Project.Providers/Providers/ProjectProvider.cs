using Cornelius.Project.Services.Providers;
using Microsoft.EntityFrameworkCore;

namespace Cornelius.Project.Providers.Providers;

public class ProjectProvider: IProjectProvider
{
    private readonly ProjectContext _projectContext;


    public ProjectProvider(ProjectContext projectContext)
    {
        _projectContext = projectContext;
    }

    public async Task<Models.Project> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var project = await _projectContext.Projects
            .Include(p => p.Images)
            .FirstOrDefaultAsync(d => d.Id == id, cancellationToken: cancellationToken).ConfigureAwait(false);
        return project;

    }

    public async Task<List<Models.Project>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _projectContext.Projects
            .Include(p => p.Images)
            .ToListAsync(cancellationToken: cancellationToken);

    }

    public async Task AddAsync(Models.Project project, CancellationToken cancellationToken)
    {
        _projectContext.Add(project);
        await _projectContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task UpdateAsync(Models.Project project, CancellationToken cancellationToken)
    {
        _projectContext.Update(project);
        await _projectContext.SaveChangesAsync(cancellationToken);
    }
}