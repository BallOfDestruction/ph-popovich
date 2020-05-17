using App.CMS;
using App.CMS.Repositories.Admin;
using App.CMS.Repositories.CmsModels;
using App.CMS.Repositories.File;
using App.CMS.Repositories.Image;
using App.Models;
using App.Repositories.Cms.Admins;
using App.Repositories.Cms.CmsModels;
using App.Repositories.Cms.Files;
using App.Repositories.Cms.Images;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App
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
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<Context>(options => options.UseSqlServer(connection));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Home/Index");
                });


            services.AddSingleton<IImageRepository, ImagesRepository>();
            services.AddSingleton<ICmsImageModelRepository, ImageCmsFakeRepository>();
            
            services.AddSingleton<ICmsAdminRepository, AdminRepository>();
            
            services.AddSingleton<ICmsFilesRepository, FileRepository>();

            services.AddSingleton<ICmsCmsModelRepository, CmsModelRepository>();

            
            services.AddSingleton(new CMSOptions()
            {
                SmptCredentialsMail = "support@ph-popovich.com",
                SmptCredentialsPassword = "8U_f41xu"
            });
            
            services.Configure<RazorViewEngineOptions>(option =>
            {
                option.ViewLocationFormats.Add("/CMS/Views/{0}" + RazorViewEngine.ViewExtension);
                option.ViewLocationFormats.Add("/CMS/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                option.ViewLocationFormats.Add("/CMS/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                option.ViewLocationFormats.Add("/CMS/Views/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
                
                option.AreaViewLocationFormats.Add("/CMS/Views/{0}" + RazorViewEngine.ViewExtension);
                option.AreaViewLocationFormats.Add("/CMS/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                option.AreaViewLocationFormats.Add("/CMS/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                option.AreaViewLocationFormats.Add("/CMS/Views/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
                
                option.PageViewLocationFormats.Add("/CMS/Views/{0}" + RazorViewEngine.ViewExtension);
                option.PageViewLocationFormats.Add("/CMS/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                option.PageViewLocationFormats.Add("/CMS/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                option.PageViewLocationFormats.Add("/CMS/Views/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
                
                option.AreaPageViewLocationFormats.Add("/CMS/Views/{0}" + RazorViewEngine.ViewExtension);
                option.AreaPageViewLocationFormats.Add("/CMS/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                option.AreaPageViewLocationFormats.Add("/CMS/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                option.AreaPageViewLocationFormats.Add("/CMS/Views/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
                
                
                option.ViewLocationFormats.Add("/{2}/Views/{0}" + RazorViewEngine.ViewExtension);
                option.ViewLocationFormats.Add("/{2}/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                option.ViewLocationFormats.Add("/{2}/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                option.ViewLocationFormats.Add("/{2}/Views/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
            });

            services.AddMvc()
                .AddMvcOptions(p => p.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}");
            });
        }
    }
}
