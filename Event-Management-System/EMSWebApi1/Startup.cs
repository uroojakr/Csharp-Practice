using Microsoft.OpenApi.Models;
using EMS.Data;
using EMS.Data.Interfaces;
using Microsoft.Extensions.Logging;
using EMSWebApi1;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        
        // Configure the database connection
        services.AddDbContext<EventManagementContext>();
        services.AddScoped<DataSeeder>();
        services.AddControllers();

        // Register services and repositories
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Swagger configuration
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "EMS-API", Version = "v1" });
        });
        services.AddLogging();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            // Enable Swagger for development environment
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "EMS-API V1");
            });

          using (var scope = app.ApplicationServices.CreateScope())
        {
            var unitOfWork = scope.ServiceProvider.GetService<IUnitOfWork>();
            var dataSeeder = scope.ServiceProvider.GetService<DataSeeder>(); // Create an instance of DataSeeder
            dataSeeder.SeedData(unitOfWork); // Call SeedData on the instance
        }
        }

        // Redirect to HTTPS in production (ensure HTTPS is configured)
        // app.UseHttpsRedirection();

        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
