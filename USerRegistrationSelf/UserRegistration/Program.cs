using BusinessLayer.Service;
using RepositoryLayer.Service;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using NLog;

var logger = NLog.LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
try
{
    logger.Info("Starting application...");
    var builder = WebApplication.CreateBuilder(args);


    // Register services for dependency injection
    builder.Services.AddScoped<IUserRegistartionBL, UserRegistrationBL>();
    builder.Services.AddScoped<IUserRegistrationRL, UserRegistrationRL>();

    // Retrieve the database connection string
    var connectionString = builder.Configuration.GetConnectionString("sqlConnection");

    // Configure the application's DbContext to use SQL Server
    builder.Services.AddDbContext<UserRegistrationContext>(options => options.UseSqlServer(connectionString));


    // Add services to the container.

    builder.Services.AddControllers();

    // Register Swagger for API documentation
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();


    var app = builder.Build();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }


    // Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

catch (Exception ex)
{
    logger.Error(ex, "Application stopped due to an exception");
throw;
}
finally
{
    LogManager.Shutdown();
}