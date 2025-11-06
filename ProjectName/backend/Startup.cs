public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        
        // Section: Dependency Injection
        services.AddScoped<IPremiumTransactionRepository, PremiumTransactionRepository>();
        services.AddScoped<IPolicyCoverageRepository, PolicyCoverageRepository>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            // Development environment middleware
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // Production environment middleware
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        // Middleware for HTTPS redirection and serving static files
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        // Middleware for authentication and authorization
        app.UseAuthentication();
        app.UseAuthorization();

        // Configuring application endpoints, such as routes
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}

