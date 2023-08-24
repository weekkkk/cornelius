using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Cornelius.Authorization.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureAppConfiguration((hostingContext, config) =>
{
    config
        .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
        .AddJsonFile("apiGateway.json", optional: false, reloadOnChange: true);
});
builder.Services.AddAuthorization(builder.Configuration);

builder.Services.AddOcelot();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

await app.UseOcelot();
app.Run();