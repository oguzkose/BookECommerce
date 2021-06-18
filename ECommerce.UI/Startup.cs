using ECommerce.ClientService.Client;
using ECommerce.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI
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
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(Startup));
            services.AddTransient<JsonSerializer>();
            //HttpClient Configurations
            services.AddHttpClient<CategoryAPIClient>(options =>
            options.BaseAddress = new Uri(Configuration.GetValue<string>("ECommerceAPIBasePath")));
            services.AddHttpClient<BookAPIClient>(options =>
            options.BaseAddress = new Uri(Configuration.GetValue<string>("ECommerceAPIBasePath")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
            pattern: "{controller=Book}/{action=Index}/{id?}");
            //pattern: "{controller=Category}/{action=Index}/{id?}");
            

            });
        }
    }
}
