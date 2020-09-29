using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ffc_backend.FccDBApi;
using ffc_backend.Model.database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ffc_backend
{
    public class Startup
    {
        private const string VERSION = "1.0.1";
        public IConfiguration Configuration { get; }
        private ILogger<Startup> mLoggerFactor;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var logger = services. mLoggerFactor.CreateLogger<Startup>();

            services.Configure<FFCDatabaseSettings>(Configuration.GetSection(nameof(FFCDatabaseSettings)));
            services.AddSingleton<IDBConnectionSettings>(sp => sp.GetRequiredService<IOptions<FFCDatabaseSettings>>().Value);
            services.AddSingleton<DBConnectionService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            mLoggerFactor = logger;
            mLoggerFactor.LogInformation("ConfigureServices started");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
