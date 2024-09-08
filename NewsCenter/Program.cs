using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ServiceInjections;
using NewsCenter.EmailService;
using NewsCenter.Models;
using Project.NewsCenter.EmailService;
using Microsoft.AspNetCore.Identity;
using System.Configuration;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); //Eger Session kompleks yapýlarla calýsmak icin Extension metodu eklenme durumuna maruz kalmýssa bu kod projenizin saglýklý calýsmasý icin gereklidir...

//builder.Services.AddSession(x =>
//{
//    x.IdleTimeout = TimeSpan.FromMinutes(5); //Projeyi kiþinin bos durma süresi eger 1 dakikalýk bir bos durma süresi olursa Session bosa cýksýn...
//    x.Cookie.HttpOnly = true; //document.cookie'den ilgili bilginin gözlemlenmesi
//    x.Cookie.IsEssential = true;
//});

// Configure authentication and authorization
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/User/Login";
    options.LogoutPath = "/User/Logout";
    // AccessDeniedPath ayarını ana sayfaya yönlendirmek için değiştiriyoruz
    options.AccessDeniedPath = "/Home";
});

builder.Services.AddIdentityServices();

builder.Services.AddDbContextService(); //DbContextService'imizi BLL'den alarak Middleware'e ekledik...
builder.Services.AddRepServices();
builder.Services.AddManagerServices();

//session kullanmak için
builder.Services.AddHttpContextAccessor();



//builder.Services.AddControllersWithViews()
//        .AddJsonOptions(options =>
//        {
//            options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
//        });

builder.Services.Configure<EmailSetting>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddTransient<IEmailService, EmailService>();
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

//app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
     name: "Admin",
     pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
