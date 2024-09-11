using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ServiceInjections;
using NewsCenter.EmailService;
using NewsCenter.Models;
using Project.NewsCenter.EmailService;
using Microsoft.AspNetCore.Identity;
using System.Configuration;
using System.Security.Policy;
using NuGet.Protocol.Core.Types;

//program.cs uygulamanın başlatılması ve yapılandırılması için gerekli tüm işlemleri ve ayarlamalrı içerir.

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();// başka API'lerle iletişim kurma veri alma ya da gönderme 
builder.Services.AddControllersWithViews(); //Bu servis, hem API hem de View tabanlı istekleri işleyebilmeyi sağlar, yani MVC yapısını etkiler

// Configure authentication(kimlik doğrulama) and authorization(yetkilendirme) ayarları
builder.Services.ConfigureApplicationCookie(options =>
{
   // burada oturum açma, çıkış yapma ve yetkisiz erişim gibi olaylar için hangi yolların(URL'lerin) kullanılacağını belirledim
    options.LoginPath = "/User/Login";
    options.LogoutPath = "/User/Logout";
    options.AccessDeniedPath = "/Home"; 
});
builder.Services.AddIdentityServices();//kullanıcının kimlik doğrulama işlemlerini ve güvenli bir oturum yönetimi yapmasını sağlar.
builder.Services.AddDbContextService(); //DbContextService'imizi BLL'den alarak Middleware'e ekledik...
builder.Services.AddRepServices();//Repository pattern, uygulama katmanları ile veritabanı arasında bir ara katman sağlar.böylece veritabanı sorgulamaları daha verimli olur 
builder.Services.AddManagerServices();//işmantığını yöneten servislerdir(bll)

// appsettings.jsondaki "EmailSettings" adlı bölümde tanımlanan e-posta ayarlarını alır ve EmailSetting sınıfına bağlar.
builder.Services.Configure<EmailSetting>(builder.Configuration.GetSection("EmailSettings"));
// E-posta gönderme servisini bağımlılık enjeksiyonu ile kullanıma sunar (her istek için yeni bir örnek oluşturur(transient)).
builder.Services.AddTransient<IEmailService, EmailService>();
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) ///eğer proje çalıştığında devolopment(yayaına alınmadan) modunda değilse.(production:yayına alınmış)
{
    app.UseExceptionHandler("/Home/Error");//herhangi bir hata olursa bu sayfaya yönlendir.
}
app.UseStaticFiles(); //static dosyaların sunulmasını sağlar(www.root) dsoyalar gibi csss ve javascript
app.UseRouting();//yönlendrime işlemleri için(hangi controller, Api, sayfa)
app.UseAuthentication();//kimlik doğrulama
app.UseAuthorization();//yetkilendirme

///admin areası aşağıdaki route tanımlaması ile projede erişilebilir,çalışılabilir hale getirirlmiştir.
app.MapControllerRoute(
     name: "Admin",
     pattern: "{area}/{controller=Home}/{action=Index}/{id?}" 
    );
//varsayılan route tanımlamssıdrı ana projenin controllerlarına ve actionlarına ulaşımı sağlar
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//yukaradaki bütütn ayarlama ve tanımları uygulama içersinde çalıştır.
app.Run();
