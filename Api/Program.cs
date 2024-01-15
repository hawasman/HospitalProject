using Api;
using Api.Helpers;
using Api.Middlewares;
using Api.Models;
using Api.Repositories;
using Api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OpenTelemetry.Metrics;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient(typeof(EFRepository<>));
builder.Services.AddTransient(typeof(EFService<>));

builder.Services.AddMultiTenant();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddOpenTelemetry().WithMetrics(opts => opts
//         .AddAspNetCoreInstrumentation()
// );

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(@"Host=localhost;Database=HPDB;Username=HPRoot;Password=1q2w3E*"));

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c =>
    {
        c.RouteTemplate = "swagger/{documentName}/swagger.json";
        c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
        {
            swaggerDoc.Servers = [new OpenApiServer { Url = $"{httpReq.Scheme}://{httpReq.Host.Value}/default" }];
        });
    });
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials());

app.UseMiddleware<TenancyMiddleware>();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/tenantInfo", (ITenant tenant) => tenant);

app.Run();