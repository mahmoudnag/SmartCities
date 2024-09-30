using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;

namespace SmartCitities.Admin.Extentions
{
    public static class ServicesExtentions
    {
        public static void ConfigureDbContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultContext"));
            });
        }
        public static void ConfigureRepositoriesAndUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

        }
        public static void ConfigureAuthenticationOptions(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(50);
                options.LoginPath = "/Account/SignIn";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.LogoutPath = "/Identity/Account/Logout";
                options.SlidingExpiration = true;
                options.ForwardAuthenticate = IdentityConstants.ApplicationScheme;
            });
        }
    }
}
