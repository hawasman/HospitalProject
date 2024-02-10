using Api.Infrastructure.Settings;
using Api.Models;
using Microsoft.Extensions.Options;

namespace Api.Services;

public interface ITenantService
{
    public string? GetDatabaseProvider();
    public string? GetConnectionString();
    public Tenant GetTenant();
}

public class TenantService : ITenantService
{
    private readonly TenantSettings _tenantSettings;
    private readonly HttpContext? _httpContext;
    private Tenant? _currentTenant;

    public TenantService(IOptions<TenantSettings> tenantSettings, IHttpContextAccessor contextAccessor)
    {
        _tenantSettings = tenantSettings.Value;
        _httpContext = contextAccessor.HttpContext;
        if (_httpContext != null)
        {
            var path = _httpContext.Request.Path.Value;

            if (path?.Split("/")[0] == "api")
            {
                if (_httpContext.Request.Headers.TryGetValue("tenant", out var tenantId))
                {
                    if (!string.IsNullOrEmpty(tenantId))
                    {
                        SetTenant(tenantId!);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Tenant!");
                }
            }else{
                SetTenant("root");
            }
        }
    }
    private void SetTenant(string tenantId)
    {
        _currentTenant = _tenantSettings.Tenants.FirstOrDefault(a => a.TID == tenantId);
        if (_currentTenant == null) throw new Exception("Invalid Tenant!");
        if (string.IsNullOrEmpty(_currentTenant.ConnectionString))
        {
            SetDefaultConnectionStringToCurrentTenant();
        }
    }
    private void SetDefaultConnectionStringToCurrentTenant()
    {
        _currentTenant!.ConnectionString = _tenantSettings.Defaults.ConnectionString;
    }
    public string? GetConnectionString()
    {
        return _currentTenant?.ConnectionString;
    }
    public string? GetDatabaseProvider()
    {
        return _tenantSettings.Defaults?.DBProvider;
    }
    public Tenant GetTenant()
    {
        return _currentTenant!;
    }
}