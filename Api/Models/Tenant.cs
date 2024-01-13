using Api.Helpers;

namespace Api.Models;

public class Tenant : BaseModel, ITenant, ITenantSetter
{
    public required string CompanyCode { get; set; }
    public required string CompanyName { get; set; }
    public int? OwnerId { get; set; }

}

public interface ITenant
{
    int Id { get; }
    string CompanyCode { get; }
    string CompanyName { get; }
    int? OwnerId { get; }
}

public interface ITenantSetter
{
    int Id { set; }
    string CompanyCode { set; }
    string CompanyName { set; }
    int? OwnerId { set; }
}