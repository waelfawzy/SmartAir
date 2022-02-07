using BLL.IRepositories;
using BLL.Repositories;
using DAL.Models;
using DAL.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SL.TokenManger;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var COrse = "AllCorse";
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var SecretKey = builder.Configuration["AppSettings:SecretKey"];
// add services to DI containe
{
    var services = builder.Services;
    
    // Add services to the container.
    services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();
    services.AddCors(c =>
    {
        c.AddPolicy(name: COrse,

        builder =>
        {
            builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
        });
    });
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("Smart Api V1", new() { Title = "Smart Air Services", Version = "Version 1" });
    });


    // configure strongly typed settings object
    services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

    // configure DI for application services
    services.AddDbContext<SmartContext>(options => options.UseSqlServer(connectionString));
    services.AddScoped<IUserRepo, UserRepo>();
    services.AddScoped<IRepoWrapper, RepoWrapper>();
    services.AddTransient<ITokenService, TokenService>();


    services.AddAuthentication(opt => {
        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey)),
            ClockSkew = TimeSpan.Zero,
        };
    });
    services.AddControllers();


}



var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Smart Api V1");
            c.RoutePrefix = String.Empty;
        });
    }
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    //app.UseMiddleware<JwtMiddleware>();

    app.UseRouting();
  
    app.UseCors(COrse);


    app.MapControllers();
    app.UseAuthentication();

    app.UseAuthorization();


    app.UseEndpoints(endpoints =>
    {

        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");
    });
    
    app.Run();

}
