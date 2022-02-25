using B2B_API.Auth;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using System.Net;
using System.Text;


var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

// For Entity Framework
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnStr")));

// For Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddMvc(config =>
{

    config.EnableEndpointRouting = false;

});
// Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




var app = builder.Build();
//app.UseMvc(); apileri bozuyor
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseRouting();

// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();



















































































//using B2B_API.Auth;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc.Authorization;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.FileProviders;
//using Microsoft.IdentityModel.Tokens;
//using System.Net;
//using System.Text;


//var builder = WebApplication.CreateBuilder(args);
//ConfigurationManager configuration = builder.Configuration;

//// Add services to the container.

//// For Entity Framework
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnStr")));

//// For Identity
//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();

//// Adding Authentication
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//})

//// Adding Jwt Bearer
//.AddJwtBearer(options =>
//{
//    options.SaveToken = true;
//    options.RequireHttpsMetadata = false;
//    options.TokenValidationParameters = new TokenValidationParameters()
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidAudience = configuration["JWT:ValidAudience"],
//        ValidIssuer = configuration["JWT:ValidIssuer"],
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
//    };
//});

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();




////builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
////{
////    x.LoginPath = "/Login/LoginForm";

////});
//builder.Services.AddAuthentication();
//builder.Services.ConfigureApplicationCookie(opt => {
//    //opt.LoginPath = new PathString("/mvc/Login/LoginForm");
//    //opt.Cookie.Name = "Website1";
//    opt.Cookie.HttpOnly = true; //js ile çekilemez
//   // opt.Cookie.SameSite = SameSiteMode.Strict; //Lax yaparsak dýþ kaynaklar cookie yi kullanabilir(baþka siteler) strict ile kullanýlamaz
//    opt.ExpireTimeSpan = TimeSpan.FromHours(2);


//}); ;
//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
//    config.Filters.Add(new AuthorizeFilter(policy));
//    config.EnableEndpointRouting = false;

//});


//var app = builder.Build();
////app.UseStatusCodePages(async context =>
////{
////    var response = context.HttpContext.Response;

////    if (response.StatusCode == (int)HttpStatusCode.Unauthorized ||
////            response.StatusCode == (int)HttpStatusCode.Forbidden)
////        response.Redirect("/mvc/Login");


////});

////app.UseFileServer(new FileServerOptions
////{
////    FileProvider = new PhysicalFileProvider(
////                    Path.Combine(Directory.GetCurrentDirectory(), "Views/Home")),
////    RequestPath = "/Views/Home",
////    EnableDefaultFiles = true
////});



//// Configure the HTTP request pipeline.
////if (app.Environment.IsDevelopment())
////{
////    app.UseSwagger();
////    app.UseSwaggerUI();
////}

//app.UseHttpsRedirection();


//app.UseStaticFiles();
//app.UseMvc();
//// Authentication & Authorization
//app.UseAuthentication();
//app.UseAuthorization();
//app.UseRouting();

//app.UseAuthorization();

////app.UseEndpoints(endpoints =>
////{
////    endpoints.MapControllerRoute(name: "areas", pattern: "{area}/{Controller=Home}/{action=Index}/{id?}");
////    endpoints.MapControllerRoute("CustomRoute", "{controller=Urun}/{action=UrunlerSayfasý}/{id?}");
////    endpoints.MapControllerRoute(
////        name: "default",
////        pattern: "{controller=Home}/{action=Index}/{id?}");

////});

//app.Run();
