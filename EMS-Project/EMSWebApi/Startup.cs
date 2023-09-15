using EMS.Business.DataService;
using EMS.Business.Interfaces;
using EMS.Data;
using EMS.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EMSWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<EMSDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("EMS-DataBase") ?? throw new InvalidOperationException("Connection string 'EMS-Database' not found.")));

            services.AddAutoMapper(typeof(BusinessMappingProfile));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEventsService, EventService>();
            services.AddScoped<IUserService, UserService>();

            // Service for Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "EMS-API",
                    Version = "v1"
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Enable Swagger and Swagger UI
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "EMS-API");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
