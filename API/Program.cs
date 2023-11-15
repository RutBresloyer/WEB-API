using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IManager326239886Context, Manager326239886Context>();
builder.Services.AddDbContext<Manager326239886Context>(o => o.UseSqlServer("Server=srv2\\pupils;Database=Manager_326239886;Trusted_Connection=True;TrustServerCertificate=True"));
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryReposery, CategoryRepository>();
builder.Services.AddScoped<IProdactRepository, ProdactRepository>();
builder.Services.AddScoped<IProdactService, ProdactService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
