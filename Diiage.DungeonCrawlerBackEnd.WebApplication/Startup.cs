using Diiage.DungeonCrawlerBackEnd.Business;
using Diiage.DungeonCrawlerBackEnd.Business.Contracts;
using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Entity.Context;
using Diiage.DungeonCrawlerBackEnd.Repository;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using Diiage.DungeonCrawlerBackEnd.WebApplication.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenIddict.Validation;
using static OpenIddict.Abstractions.OpenIddictConstants;

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

            
            
            
            services.AddCors();
            services.AddControllersWithViews();
            services.AddMvc();

            services.AddDbContext<DungeonCrawlerDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Server = MSI; Database = DungeonCrawlerDbContext; User Id=user; Password=Azerty@123; Trusted_Connection = True; MultipleActiveResultSets = true"));
                options.UseOpenIddict();
            });

            services.AddOpenIddict()

                // Register the OpenIddict core components.
                .AddCore(options =>
                {
                    // Configure OpenIddict to use the Entity Framework Core stores and models.
                    // Note: call ReplaceDefaultEntities() to replace the default OpenIddict entities.
                    options.UseEntityFrameworkCore()
                           .UseDbContext<DungeonCrawlerDbContext>();
                })

                // Register the OpenIddict server components.
                .AddServer(options =>
                {
                    options.UseMvc();
                    
                    
                    // Enable the token endpoint.
                    options.EnableTokenEndpoint("/connect/token");

                    // Enable the password flow.
                    options.AllowPasswordFlow();

                    // Accept anonymous clients (i.e clients that don't send a client_id).
                    options.AcceptAnonymousClients();

                    //options.DisableHttpsRequirement();
                                      
                })

                .AddValidation();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = OpenIddictValidationDefaults.AuthenticationScheme;
            }
            );

            
            
            services.AddSignalR();

            
            ///injection de dépendences
            services.AddScoped<ICharacterRepository, DbCharacterRepository>();
            services.AddScoped<IAuthentificationService, AuthentificationService>();
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI"));
            }
            //app.UseHttpsRedirection();
            //app.UseHsts();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

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
