using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminClient.Model.Product;
using AdminClient.Model.Restaurant;
using AdminClient.Model.Store;
using AdminClient.Model.Story;
using AdminClient.Model.Utility;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Licensing;

namespace AdminClient
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            string licenseKey = "Mgo+DSMBMAY9C3t2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5Xd0JiW39XdHNXRmBb\r\n";
            SyncfusionLicenseProvider.RegisterLicense(licenseKey);
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });
            services.AddControllersWithViews();
            services.AddScoped<IHttpWebClients, HttpWebClients>();
            services.AddScoped<IStore, StoreProvider>();
            services.AddScoped<IProduct, ProductProvider>();
            services.AddScoped<IRestaurantImage, RestaurantImageProvider>();

            services.AddScoped<IStory, StoryProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error/exception");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }
             app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Login}/{id?}");

            });
        }
    }
}
