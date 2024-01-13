using Api.Models;

namespace Api.Helpers;

public static class Extentions
{
    public static IServiceCollection AddMultiTenant(this IServiceCollection services)
    {
        services.AddScoped<ITenancyManager, TenancyManager>();
        services.AddScoped<Tenant>();
        services.AddScoped<ITenant>(s => s.GetRequiredService<Tenant>());
        services.AddScoped<ITenantSetter>(s => s.GetRequiredService<Tenant>());

        return services;
    }
}