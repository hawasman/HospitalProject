using Api.Helpers;

namespace Api.Models;

public class Examination : BaseModel, ITenantModel
{
    public int BillId { get; set; }
    public required string ServiceType { get; set; }
    public required string Name { get; set; }
    public required string Result { get; set; }
    public required string Unit { get; set; }
    public required string Normal { get; set; }
    public ICollection<Attachment>? Attachments { get; set; }
    public string? TenantId { get; set; }
}