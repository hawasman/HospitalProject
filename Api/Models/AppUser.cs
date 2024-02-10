using Microsoft.AspNetCore.Identity;
using Riok.Mapperly.Abstractions;

namespace Api.Models;

public class AppUser : IdentityUser, ITenantModel
{
    public string? TenantId { get; set; }
}

public class AppUserDto
{
    public Guid Id { get; set; }
    public string TenantId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; } = string.Empty;

}

[Mapper]
public static partial class UserMapper
{
    [MapperIgnoreSource(nameof(AppUser.NormalizedEmail))]
    [MapperIgnoreSource(nameof(AppUser.NormalizedUserName))]
    [MapperIgnoreSource(nameof(AppUser.EmailConfirmed))]
    [MapperIgnoreSource(nameof(AppUser.PasswordHash))]
    [MapperIgnoreSource(nameof(AppUser.SecurityStamp))]
    [MapperIgnoreSource(nameof(AppUser.ConcurrencyStamp))]
    [MapperIgnoreSource(nameof(AppUser.PhoneNumberConfirmed))]
    [MapperIgnoreSource(nameof(AppUser.TwoFactorEnabled))]
    [MapperIgnoreSource(nameof(AppUser.LockoutEnabled))]
    [MapperIgnoreSource(nameof(AppUser.LockoutEnd))]
    [MapperIgnoreSource(nameof(AppUser.AccessFailedCount))]
    public static partial AppUserDto ToDto(AppUser user);
}