using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Identity.Client;

namespace Api.Helpers;

public interface ITenancyManager
{
    Task<Tenant?> GetTenant(string tenantName);
}

public class TenancyManager : ITenancyManager
{

    private readonly AppDbContext _context;

    public TenancyManager(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Tenant?> GetTenant(string tenantName)
    {
        if (tenantName == "default")
        {
            return new Tenant
            {
                Id = 0,
                ActiveField = true,
                CompanyCode = "Main",
                CompanyName = "Project",
                CreatedAt = DateTime.Now,
                OwnerId = 0,
                TenantId = 0,
                UserId = 0
            };
        }

        var tenant = await _context.Tenants.FirstOrDefaultAsync(x => x.CompanyName == tenantName);

        return tenant;

    }
}
