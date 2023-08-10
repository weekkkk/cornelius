using Cornelius.Project.Services.Request;
using Cornelius.Project.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace Cornelius.Project.API.Controllers;

public class ProjectController: ApiBaseController
{
    private readonly IProjectService _projectService;


    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpPost(Name = "CreateProject")]
    public async Task<IActionResult> CreateAsync(ProjectRequest project)
    {
        ArgumentNullException.ThrowIfNull(project);
        await _projectService.CreateAsync(project, new CancellationToken());
        return Ok();
    }
    [HttpPut(Name = "UpdateProject")]
    public async Task<IActionResult> UpdateAsync(ProjectRequest project)
    {
        ArgumentNullException.ThrowIfNull(project);
        await _projectService.UpdateAsync(project, new CancellationToken());
        return Ok();
    }
    [HttpGet(Name = "GetAllProject")]
    public async Task<List<Models.Project>> GetAll()
    {
        var listProjects = await _projectService.GetAllAsync(new CancellationToken());
        return listProjects;
    }
    [HttpGet("{id}")]
    public async Task<Models.Project> GetById(Guid id)
    {
        var project = await _projectService.GetByIdAsync(id, new CancellationToken());
        return project;
    }
}
