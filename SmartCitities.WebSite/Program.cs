using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;
using SmartCitities.WebSite.Helpers;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;
AppConfig.Initialize(configuration);
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
string? connectionString = builder.Configuration.GetConnectionString("cs");
builder.Services.AddDbContext<ApplicationDbContext>(
    OptionsBuilder => { OptionsBuilder.UseSqlServer(connectionString); }

    );

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{


    app.UseExceptionHandler("/Home/Error");


    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();
app.UseStatusCodePagesWithReExecute("/Home/NotFound", "?statusCode={0}");


app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
