using BuilderApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<ProductBuilder>();

var app = builder.Build();

app.MapControllers();   

app.Run();
