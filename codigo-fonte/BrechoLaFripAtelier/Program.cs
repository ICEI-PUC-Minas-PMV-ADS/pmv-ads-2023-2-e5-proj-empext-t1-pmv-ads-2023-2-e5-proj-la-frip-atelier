using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BrechoLaFripAtelier.Data;
using BrechoLaFripAtelier.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BrechoLaFripAtelierContextConnection") ?? throw new InvalidOperationException("Connection string 'BrechoLaFripAtelierContextConnection' not found.");

builder.Services.AddDbContext<BrechoLaFripAtelierContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<UsuarioModel>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<BrechoLaFripAtelierContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
