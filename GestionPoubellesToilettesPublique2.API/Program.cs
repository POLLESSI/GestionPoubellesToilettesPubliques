using GestionPoubellesToilettesPublique2.API.Tools;
using GestionPoubellesToilttesPubliques2.DAL.Repositories;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using GestionPoubellesToilettresPubliques2.BLL.Services;
using GestionPoubellesToilettesPublique2.API.Hubs;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using GestionPoubellesToilettresPubliques2.BLL.Models;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using BelgianCaveRegister_Api.Tools;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(o => o.AddPolicy("mypolicy", options => options.WithOrigins("http://localhost:7281", "http://localhost:")
                .AllowCredentials()
                .AllowAnyHeader()
                .AllowAnyMethod()));

// SqlConnection

builder.Services.AddScoped<SqlConnection>(Sp => new SqlConnection(builder.Configuration.GetConnectionString("default")));

// Injections

builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<IChatRepository, ChatRepository>();
builder.Services.AddScoped<INUserService, NUserService>();
builder.Services.AddScoped<INUserRepository, NUserRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ISaveStreetService, SaveStreetService>();
builder.Services.AddScoped<ISaveStreetRepository, SaveStreetRepository>();

// SignalR (optionnel)
builder.Services.AddSignalR();
builder.Services.AddSingleton<ChatHub>();
builder.Services.AddSingleton<NUserHub>();
builder.Services.AddSingleton<PersonHub>();
builder.Services.AddSingleton<SaveStreetHub>();

// Token Generator

builder.Services.AddScoped<TokenGenerator>();

// Security levels

builder.Services.AddAuthorization(o =>
{
    o.AddPolicy("adminpolicy", option => option.RequireRole("admin"));
    o.AddPolicy("modopolicy", option => option.RequireRole("admin", "modo"));
    o.AddPolicy("userpolicy", option => option.RequireAuthenticatedUser());
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(option =>
        {
            option.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenGenerator.secretKey)),
                ValidateLifetime = true,
                ValidateIssuer = false,
                ValidateAudience = false,
            };
        });

//builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseExceptionHandler("/Home/Error");
    //// The default HSTS is 30 days. You want to change this for production scenarios, see https://aka.ms/aspnetcore.hsts.
    //app.UseHsts();
    //c =>
    //{
    //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "belgiancavesregister_api");
    //}
}
//app.UseCors(o => o.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
app.UseCors("mypolicy");

app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//      name: "default",
//      pattern: "{controller-Home}/{action=Index}/Iid?}"
//      );

app.MapControllers();

// Optionnel

app.MapHub<ChatHub>("/chathub");
app.MapHub<NUserHub>("/nuserhub");
app.MapHub<PersonHub>("/personhub");
app.MapHub<SaveStreetHub>("/savestreethub");

// Optionnel (si razor)

//app.MapRazorPages();

app.Run();
