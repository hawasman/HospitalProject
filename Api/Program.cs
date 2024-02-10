using System.Security.Claims;
using Api;
using Api.Infrastructure.Extensions;
using Api.Infrastructure.Settings;
using Api.Models;
using Api.Repositories;
using Api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

builder.Services.AddTransient(typeof(EFRepository<>));
builder.Services.AddTransient(typeof(EFService<>));
builder.Services.AddScoped<ITenantService, TenantService>();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.Configure<TenantSettings>(builder.Configuration.GetSection(nameof(TenantSettings)));
builder.Services.AddAndMigrateTenantDatabases(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddAuthorization();
builder.Services.AddAuthorizationBuilder();
builder.Services.AddIdentityApiEndpoints<AppUser>()
    .AddEntityFrameworkStores<AppDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials());


app.UseRouting();

app.UseAuthorization();

app.MapIdentityApi<AppUser>();

app.MapGet("/user", async (HttpContext context, UserManager<AppUser> userManager) => {
   var user = await userManager.GetUserAsync(context.User);
   if(user == null){
        return Results.NotFound();
   }
   
   return Results.Ok(UserMapper.ToDto(user));
}).RequireAuthorization();

app.MapControllers();

app.Run();