using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Inciwiki.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;

namespace Inciwiki
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
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization();

            services.Configure<RequestLocalizationOptions>(
                opt => {
                   var supportedCultures = new List<CultureInfo>
                   {
                            new CultureInfo("tr"),
                            new CultureInfo("en"),
                   };
                   opt.DefaultRequestCulture = new RequestCulture("tr");
                   opt.SupportedCultures = supportedCultures;
                   opt.SupportedUICultures = supportedCultures;
                });

                //services.AddDbContext<ApplicationDbContext>(options =>
                //    options.UseSqlServer(
                //        Configuration.GetConnectionString("DefaultConnection")));
                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<ApplicationDbContext>();
                //services.AddControllersWithViews();
                //services.AddRazorPages();

                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection")));
                services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                     .AddDefaultUI()
                     .AddEntityFrameworkStores<ApplicationDbContext>()
                     .AddDefaultTokenProviders();
                services.AddControllersWithViews();
                services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            // Localization Ayarlarý
            //var supportedCultures = new[] { "tr", "en" };
            //var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
            //    .AddSupportedCultures(supportedCultures)
            //    .AddSupportedUICultures(supportedCultures);
            //app.UseRequestLocalization(localizationOptions);

            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
