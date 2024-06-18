using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace YourNamespace
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Metoda konfiguracji serwisów aplikacji
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("MagazynierPolicy", policy =>
                    policy.RequireRole("Magazynier"));

                options.AddPolicy("SerwisPolicy", policy =>
                    policy.RequireRole("Serwis"));

                options.AddPolicy("KlientPolicy", policy =>
                    policy.RequireRole("Klient"));
            });

            // Konfiguracja serwisów, np. dodawanie DbContext, autentykacja, Swagger, inne usługi
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Your API", Version = "v1" });
            });
        }

        // Metoda konfiguracji middleware'ów aplikacji
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Obsługa środowiska deweloperskiego
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
                    c.RoutePrefix = string.Empty; // Swagger UI at the app's root
                });
            }

            // Inne middleware'y, np. autentykacja, routowanie, obsługa błędów, statyczne pliki, CORS, itp.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
