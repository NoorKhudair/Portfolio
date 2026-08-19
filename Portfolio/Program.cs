using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Data.Interceptors;
using Portfolio.Helpers.Email;
using Portfolio.Helpers.File;
using Portfolio.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<DataDbContext>(x =>
x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
.AddInterceptors(new SoftDeleteInterceptor()));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddSingleton<IEmailHelper, EmailHelper>();
builder.Services.AddSingleton<IFileHelper, FileHelper>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DataDbContext>();

//IDENTITY CONFIG
builder.Services.Configure<IdentityOptions>(x =>
{
    x.Password.RequiredUniqueChars = 0;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequiredLength = 3;
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
    x.Password.RequireDigit = false;
});
 

builder.Services.ConfigureApplicationCookie(x =>
{ 
x.LoginPath = "/Admin/Account/Login";
x.LogoutPath = "/Admin";
x.ExpireTimeSpan = TimeSpan.FromMinutes(15);
x.SlidingExpiration = true;

});

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
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseDeveloperExceptionPage();
app.Run();
