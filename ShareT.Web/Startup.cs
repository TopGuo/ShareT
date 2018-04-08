using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShareT.Common;
using ShareT.Data;
using ShareT.Mongo;
using ShareT.Service;

namespace ShareT.Web
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
            new MvcHelper().InitConfiguration(Configuration);
            services.AddDbContext<DbTestEntity_1Context>(option => option.UseSqlServer(MvcHelper.DbConnectionT1));
            services.AddDbContext<DbTestEntity_2Context>(option => option.UseSqlServer(MvcHelper.DbConnectionT2));

            //services.AddDbContext<MongoContext>(option => option.UseSqlServer(MvcHelper.DbConnectionMongo));

            services.AddScoped<PersonInfoesService, PersonInfoesService>();
            services.AddScoped<StudentsInfoService, StudentsInfoService>();

            //Ìí¼Ó mongodb
            services.AddMongoContext<DemoMongoContext>(options=>options.UseMongo(Configuration.GetConnectionString("MongoConnection")));

            //Ìí¼ÓÄÚ´æ»º´æ
            services.AddMemoryCache();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            //app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=PersonInfoes}/{action=Index}/{id?}");
            });

        }
    }
}
