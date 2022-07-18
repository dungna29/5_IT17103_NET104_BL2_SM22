using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_2_RequestPipeline_MiddleWare
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
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /*
         * request pipeline
         */

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            /*
             * Xây dựng 1 Middleware
             * Sử dụng Next để đi tiếp sang các middleware khác.
             */
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<h1> C#4 Hello Middleware 1 FPOLY </h1>");
                await next.Invoke();//Nó sẽ gọi đến Middlware tiếp theo

                await context.Response.WriteAsync("<h1> C#4 Response Hello Middleware 1 FPOLY </h1>");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<h1> C#4 Hello Middleware 2 FPOLY</h1>");
                await next.Invoke();

                //Sau khi có Invoke thì nó sẽ quay lại can thiệp tiếp vào lần thứ 2
                await context.Response.WriteAsync("<h1> C#4 Response Hello Middleware 2 FPOLY </h1>");
            });

            //Xây dựng Midelware Run
            //Endpoint
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1> C#4 Hello Middleware 3 FPOLY</h1>");
            });
        }
    }
}