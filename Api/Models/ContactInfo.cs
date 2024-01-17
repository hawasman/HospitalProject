using Api.Helpers;

namespace Api.Models;

public class ContactInfo : BaseModel, ITenantModel
{
    public required string Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? MobilePhone { get; set; }
    public string? Email { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public string? TenantId { get; set; }
}