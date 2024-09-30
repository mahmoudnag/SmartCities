using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartCities.Core.Models;
using SmartCities.Core;
using SmartCities.EF;
using SmartCitities.Admin.Extentions;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") 
    ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");


builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureAuthenticationOptions();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.ConfigureRepositoriesAndUnitOfWork();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/SignIn";
    options.AccessDeniedPath = "/User/AccessDenied";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
   // app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapAreaControllerRoute(
                name: "Identity",
                areaName: "Identity",
                pattern: "Identity/{controller=Account}/{action=Login}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
