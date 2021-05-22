using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public string AllowPolicy => "MyPolicy";
        // This method gets called by the runtime. Use this method to add services to the container.
        // EmpresaNombre(PascalCase)   => EmpresaNombre(calmeCase)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDIContainer();

            services.AddControllers().AddJsonOptions(option=> {
                option.JsonSerializerOptions.DictionaryKeyPolicy = null;
                option.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            services.AddCors(options=> {

                options.AddPolicy(AllowPolicy, builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(AllowPolicy);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
