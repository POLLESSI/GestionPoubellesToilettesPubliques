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

builder.Services.AddScoped<IAddresService, AddresService>();
builder.Services.AddScoped<IAddresRepository, AddresRepository>();
builder.Services.AddScoped<IAshtrayService, AshtrayService>();
builder.Services.AddScoped<IAshtrayRepository, AshtrayRepository>();
builder.Services.AddScoped<ICanisiteService, CanisiteService>();
builder.Services.AddScoped<ICanisiteRepository, CanisiteRepository>();
builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<IChatRepository, ChatRepository>();
builder.Services.AddScoped<IEvenementService, EvenementService>();
builder.Services.AddScoped<IEvenementRepository, EvenementRepository>();
builder.Services.AddScoped<IGarbageCanService, GarbageCanService>();
builder.Services.AddScoped<IGarbageCanRepository, GarbageCanRepository>();
builder.Services.AddScoped<IIncivilityService, IncivilityService>();
builder.Services.AddScoped<IIncivilityRepository, IncivilityRepository>();
builder.Services.AddScoped<IMapService, MapService>();
builder.Services.AddScoped<IMapRepository, MapRepository>();
builder.Services.AddScoped<INUserService, NUserService>();
builder.Services.AddScoped<INUserRepository, NUserRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ISaveStreetService, SaveStreetService>();
builder.Services.AddScoped<ISaveStreetRepository, SaveStreetRepository>();
builder.Services.AddScoped<IMakeshiftSchelterService, MakeshiftSchelterService>();
builder.Services.AddScoped<IMakeshiftShelterRepository, MakeshiftShelterRepository>();
builder.Services.AddScoped<IPublicToiletService, PublicToiletService>();
builder.Services.AddScoped<IPublicToiletRepository, PublicToiletteRepository>();

// SignalR (optionnel)
builder.Services.AddSignalR();
builder.Services.AddSingleton<AddresHub>();
builder.Services.AddSingleton<AshtrayHub>();
builder.Services.AddSingleton<CanisiteHub>();
builder.Services.AddSingleton<ChatHub>();
builder.Services.AddSingleton<EvenementHub>();
builder.Services.AddSingleton<GarbageCanHub>();
builder.Services.AddSingleton<IncivilityHub>();
builder.Services.AddSingleton<MapHub>();
builder.Services.AddSingleton<NUserHub>();
builder.Services.AddSingleton<PersonHub>();
builder.Services.AddSingleton<PublicToiletHub>();
builder.Services.AddSingleton<SaveStreetHub>();
builder.Services.AddSingleton<MakeshiftShelterHub>();

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

app.MapHub<AddresHub>("/addreshub");
app.MapHub<AshtrayHub>("/ashtrayhub");
app.MapHub<CanisiteHub>("/canisite");
app.MapHub<ChatHub>("/chathub");
app.MapHub<EvenementHub>("/evenementhub");
app.MapHub<GarbageCanHub>("/garbagecanhub");
app.MapHub<IncivilityHub>("/incivility");
app.MapHub<MapHub>("/map");
app.MapHub<NUserHub>("/nuserhub");
app.MapHub<PersonHub>("/personhub");
app.MapHub<PublicToiletHub>("/publictoilethub");
app.MapHub<SaveStreetHub>("/savestreethub");
app.MapHub<MakeshiftShelterHub>("/makeshiftschelterhub");

// Optionnel (si razor)

//app.MapRazorPages();

app.Run();
