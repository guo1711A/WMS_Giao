using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WMS_DataAccess.Colin_DataAccess;

namespace WMS_Project
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
            services.AddCors(option => option.AddPolicy("mycors", p => p.AllowAnyOrigin()));
            services.AddSingleton<IDA, SqlDbHelper>();
            //Hanna的DAL接口实现
            services.AddSingleton<WMS_DataAccess.Hanna_DataAccess.IDAL,WMS_DataAccess.Hanna_DataAccess.DALSqlHelper>();
            //Hanna的BLL接口实现
            services.AddSingleton<WMS_Business.Hanna_Buniness.IBLL, WMS_Business.Hanna_Buniness.Business>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("mycors");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
