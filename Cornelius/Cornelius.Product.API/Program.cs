using Cornelius.Product.Providers;
using Cornelius.Product.Providers.Providers;
using Cornelius.Product.Services;
using Cornelius.Product.Services.Providers;
using Cornelius.Product.Services.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductContext>();
builder.Services.AddScoped<IProductProvider, ProductProvider>();
builder.Services.AddScoped<IProductService, ProductService>();

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