using AwesomeShopDesignPatterns.Application;
using AwesomeShopDesignPatterns.Application.NotifyUser;
using AwesomeShopDesignPatterns.Infrastructure.Services;
using AwesomeShopDesignPatterns.Models;
using Microsoft.Extensions.Configuration;
using SendGrid.Extensions.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var sendGridApiKey = builder.Configuration.GetSection("SendGridApiKey").Value;
builder.Services.AddSendGrid(o => o.ApiKey = sendGridApiKey);

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    Log.Logger = new LoggerConfiguration()
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .CreateLogger();
}).UseSerilog();

builder.Services.AddScoped<INotificationFactoryService, NotificationFactoryService>();
builder.Services.AddScoped<NotifyUserCommandHandler>();
builder.Services.AddScoped<ICommandHandler<NotifyUserCommand, Task>, NotifyUserCommandHandlerDecorator>();
builder.Services.AddScoped<IMediator, Mediator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
