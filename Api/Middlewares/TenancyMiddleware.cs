using Api.Helpers;
using Api.Models;

namespace Api.Middlewares;

public class TenancyMiddleware
{
    // private readonly RequestDelegate _next;

    // public TenancyMiddleware(RequestDelegate next)
    // {
    //     _next = next;
    // }

    // public async Task InvokeAsync(HttpContext context, ITenancyManager tenancyManager, ITenantSetter tenant)
    // {
    //     var path = context.Request.Path;

    //     if (!path.HasValue)
    //     {
    //         context.Response.StatusCode = 500;
    //         return;
    //     }

    //     var segments = path.Value
    //                 .Split("/")
    //                 .Where(x => x != string.Empty)
    //                 .ToArray();
    //     if (segments.Length <= 1)
    //     {
    //         context.Response.StatusCode = 400;
    //         await context.Response.WriteAsJsonAsync(new {
    //             status = "TENANT_IS_MISSING",
    //             message = "Tenant is missing from request."
    //         });
    //         return;
    //     }

    //     var tenantName = segments.FirstOrDefault();
        
    //     var currentTenant = await tenancyManager.GetTenant(tenantName);

    //      if (currentTenant == null)
    //     {
    //         context.Response.StatusCode = 404;
    //         await context.Response.WriteAsJsonAsync(new {
    //             status = "TENANT_IS_NOT_REGISTERED",
    //             message = $"Tenant {tenantName} is not registered."
    //         });
    //         return;
    //     }

    //     tenant.Id = currentTenant.Id;
    //     tenant.CompanyName = currentTenant.CompanyName;
    //     tenant.TID = currentTenant.TID;
    //     tenant.OwnerId = currentTenant.OwnerId;

    //     context.Request.Path = "/" + string.Join("/", segments.Skip(1));

    //     await _next(context);
    // }
}