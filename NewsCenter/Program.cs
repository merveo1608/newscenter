using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ServiceInjections;
using NewsCenter.EmailService;
using NewsCenter.Models;
using Project.COREMVC.EmailService;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); //Eger Session kompleks yap�larla cal�smak icin Extension metodu eklenme durumuna maruz kalm�ssa bu kod projenizin sagl�kl� cal�smas� icin gereklidir...

builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromMinutes(5); //Projeyi ki�inin bos durma s�resi eger 1 dakikal�k bir bos durma s�resi olursa Session bosa c�ks�n...
    x.Cookie.HttpOnly = true; //document.cookie'den ilgili bilginin g�zlemlenmesi
    x.Cookie.IsEssential = true;
});

builder.Services.AddIdentityServices();

builder.Services.AddDbContextService(); //DbContextService'imizi BLL'den alarak Middleware'e ekledik...
builder.Services.AddRepServices();
builder.Services.AddManagerServices();

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

app.UseSession();

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
