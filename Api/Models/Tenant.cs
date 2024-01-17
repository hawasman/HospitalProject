using Api.Helpers;

namespace Api.Models;

public class Tenant : BaseModel, ITenant, ITenantSetter, ITenantModel
{
    public required string TID { get; set; }
    public required string CompanyName { get; set; }
    public string ConnectionString { get; set; } = string.Empty;
    public int? OwnerId { get; set; }
    public string? TenantId { get; set; }
}

public interface ITenant
{
    int Id { get; }
    string TID { get; }
    string CompanyName { get; }
    int? OwnerId { get; }
}

public interface ITenantSetter
{
    int Id { set; }
    string TID { set; }
    string CompanyName { set; }
    int? OwnerId { set; }
}

public interface ITenantModel
{
    public string? TenantId { get; set; }
}