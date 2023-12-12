using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using TaskManagmentSystem.Models;


namespace TaskManagmentSystem;


public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        // Add services, configurations, and dependencies here

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Server=iashka; Database=TaskManagmentSystem; Integrated Security=true; TrustServerCertificate=true;")));

        // Add other services, middleware, and configurations as needed
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configure middleware and request pipeline here

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // Configure error handling for production
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        // Configure other middleware and routing as needed
    }
}
