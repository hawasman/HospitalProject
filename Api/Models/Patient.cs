using System.Globalization;
using Api.Helpers;

namespace Api.Models;

public class Patient : BaseModel
{
    public string? FullNameEnglish { get; set; }
    public required string FullNameArabic { get; set; }
    public required DateTime BirthDate { get; set;  }
    public required string Nationality { get; set; }
    public required Gender Gender { get; set; }
    public required SocialState SocialState { get; set; }
    public required string Religion { get; set; }
    public required string NationalId { get; set; }
    public string? Job { get; set; }
    public ContactInfo? ContactInfo { get; set; }
    public FinancialInfo? FinancialInfo { get; set; }
    public ICollection<Attachment>? Attachments { get; set; }
    public MedicalFile? MedicalFile { get; set; }

}