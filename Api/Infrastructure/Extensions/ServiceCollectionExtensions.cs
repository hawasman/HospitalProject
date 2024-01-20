using Api.Infrastructure.Settings;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAndMigrateTenantDatabases(this IServiceCollection services, IConfiguration config)
    {
        var options = services.GetOptions<TenantSettings>(nameof(TenantSettings));
        var defaultConnectionString = options.Defaults?.ConnectionString;
        var defaultDbProvider = options.Defaults?.DBProvider;
        if (defaultDbProvider?.ToLower() == "postegresql")
        {
            services.AddDbContext<AppDbContext>(m => m.UseNpgsql(defaultConnectionString));
        }

        var tenants = options.Tenants;
        foreach (var tenant in tenants)
        {
            string? connectionString = string.IsNullOrEmpty(tenant.ConnectionString)
                ? defaultConnectionString
                : tenant.ConnectionString;

            using var scope = services.BuildServiceProvider().CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            dbContext.Database.SetConnectionString(connectionString);

            if (dbContext.Database.GetMigrations().Any())
            {
                dbContext.Database.Migrate();
            }
        }

        return services;
    }
    public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : new()
    {
        using var serviceProvider = services.BuildServiceProvider();
        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
        var section = configuration.GetSection(sectionName);
        var options = new T();
        section.Bind(options);
        return options;
    }
}