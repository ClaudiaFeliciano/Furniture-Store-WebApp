using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFTFurnitureWeb.Models;
using CFTFurnitureWeb.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace CFTFurnitureWeb
    {
    public class Startup
        {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
            {
            services.AddTransient<IPasswordValidator<AppUser>,CustomPasswordValidator>();
            services.AddTransient<IUserValidator<AppUser>,CustomUserValidator>();
            services.AddDbContext<ApplicationDbContext>(options =>
                                                        options.UseSqlServer(
                                                            Configuration["Data:CFTFurnitureWebFurnitures:ConnectionString"]));
            services.AddDbContext<AppIdentityDbContext>(options =>
                                                        options.UseSqlServer(
                                                            Configuration["Data:CFTFurnitureWebIdentity:ConnectionString"]));
            services.AddIdentity<AppUser, IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = true;
            }).AddEntityFrameworkStores<AppIdentityDbContext>()
                    .AddDefaultTokenProviders();
            services.AddTransient<IFurnitureRepository, EFFurnitureRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
            }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
            {
            if (env.IsDevelopment())
                {
                app.UseDeveloperExceptionPage();
                }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            AppIdentityDbContext.CreateAdminAccount(app.ApplicationServices, Configuration).Wait();
            app.UseMvc(routes => {
                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
                routes.MapRoute(
                name: "default",
                template: "{controller=Furniture}/{action=Index}/{id?}");

                routes.MapRoute(
                name: null,
                template: "{category}/Page{productPage:int}",
                defaults: new { controller = "Furniture", action = "List" }
                );

                routes.MapRoute(
                name: null,
                template: "Page{productPage:int}",
                defaults: new { controller = "Furniture", action = "List", productPage = 1 }
                );

                routes.MapRoute(
                name: null,
                template: "{category}",
                defaults: new { controller = "Furniture", action = "List", productPage = 1 }
                );

                routes.MapRoute(
                name: null,
                template: "",
                defaults: new { controller = "Furniture", action = "List", productPage = 1 });
            });
            SeedData.EnsurePopulated(app);
          
            }
        }
    }
