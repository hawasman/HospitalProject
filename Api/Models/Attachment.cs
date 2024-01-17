using Api.Helpers;

namespace Api.Models;

public class Attachment : BaseModel, ITenantModel
{
    public required string Name { get; set; }
    public required string Type { get; set; }
    public required string Path { get; set; }
    public string? Size { get; set; }
    public string? Notes { get; set; }
    public string? TenantId { get; set; }
}