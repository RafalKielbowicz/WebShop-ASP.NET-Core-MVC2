﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Data;

namespace WebShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => 
            Configuration = configuration;
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                Configuration["Data:WebShopProducts:ConnectionString"]));
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: null,
                    template: "{category}/Page{page:int}",
                    defaults: new { controller = "Product", action = "ProductsList"}
                );
                routes.MapRoute(
                    name: null,
                    template: "Page{page:int}",
                    defaults: new { controller = "Product", action = "ProductsList"}
                );
                routes.MapRoute(
                    name: null,
                    template: "{category}",
                    defaults: new { controller = "Product", action = "ProductsList", productPage = 1}
                );
                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults: new { controller = "Product", action = "ProductsList", productPage = 1}
                );
                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
