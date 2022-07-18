using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Bai_6_Controller_Actions_Routing
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            // app.UseStatusCodePages(context =>
            // {
            //     var request = context.HttpContext.Request;
            //     var response = context.HttpContext.Response;
            //     var code = response.StatusCode;
            //
            //     if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
            //     {
            //         response.Redirect("/sinh-vien");
            //     }
            //
            //     return Task.CompletedTask;
            // });

            app.UseEndpoints(endpoints =>
            {
                //Multiple Routes: Tạo ra nhiều route bên trong UseEndpoints() bằng nhiều MapControllerRoute()

                // endpoints.MapControllerRoute(
                //     name: "default",
                //     pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=SinhVien}/{action=Index}/{id?}");
            });
        }
    }
}