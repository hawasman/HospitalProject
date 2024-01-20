using Microsoft.AspNetCore.Identity;

namespace Api.Models;

public class AppUser : IdentityUser, ITenantModel
{
    public string? TenantId {get; set;}
}