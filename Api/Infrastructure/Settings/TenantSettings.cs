using Api.Models;

namespace Api.Infrastructure.Settings;

public class TenantSettings
{
    public Configuration Defaults { get; set; } = null!;
    public List<Tenant> Tenants { get; set; } = null!;
}

public class Configuration
{
    public string DBProvider { get; set; } = string.Empty;
    public string ConnectionString { get; set; } = string.Empty;
}