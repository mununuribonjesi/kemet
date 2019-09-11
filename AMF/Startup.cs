using System;
using AMF.Data.Interfaces.Repositories;
using AMF.Data.Repositories;
using AMF.Entities.Models;
using AMF.Infrastructure.Interfaces;
using AMF.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AMF
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddEntityFrameworkNpgsql().AddDbContext<DatabaseContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/dist"; });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //Mailing List Table
            services.AddScoped<IMailingListRepository, MailingListRepository>();
            services.AddScoped<IMailingListService, MailingListService>();
            //Countries Table
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<ICountriesService, CountriesService>();
            //Email Table 
            services.AddScoped<IEmailRepository, EmailRepository>();
            services.AddScoped<IEMailService, EmailService>();
        }        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseCors(builder => builder.AllowAnyMethod()
              .AllowAnyHeader()
              .AllowAnyOrigin()
              .Build());
            app.UseSpaStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";
                if (env.IsDevelopment())
                {
                    spa.Options.StartupTimeout = new TimeSpan(0, 0, 80);
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
