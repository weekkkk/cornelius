using Cornelius.Project.Providers;
using Cornelius.Project.Providers.Providers;
using Cornelius.Project.Services;
using Cornelius.Project.Services.Providers;
using Cornelius.Project.Services.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProjectContext>();
builder.Services.AddScoped<IProjectProvider, ProjectProvider>();
builder.Services.AddScoped<IProjectService, ProjectService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("ReactPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();