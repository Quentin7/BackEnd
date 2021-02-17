using Diiage.DungeonCrawlerBackEnd.Business;
using Diiage.DungeonCrawlerBackEnd.Business.Contracts;
using Diiage.DungeonCrawlerBackEnd.Entity.Context;
using Diiage.DungeonCrawlerBackEnd.Repository;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using Diiage.DungeonCrawlerBackEnd.WebApplication.Hubs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication
{
    public class Startup
    {

        internal static IConfiguration Configuration { get; private set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            DungeonCrawlerDbContext context = new DungeonCrawlerDbContext(Configuration);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            SeedDataLocal.Initialize();
            context.Dispose();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });
            services.AddMvc();
            services.AddCors();
            services.AddSignalR();

            ///injection de dépendences
            services.AddScoped<ICharacterRepository, DbCharacterRepository>();
            services.AddScoped<IAuthentificationService, AuthentificationService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<AuthentificationHub>("/authentification-hub");
            });

            app.UseCors(builder =>
                builder
                    .WithOrigins("http://localhost:8080")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
            );
        }
    }
}
