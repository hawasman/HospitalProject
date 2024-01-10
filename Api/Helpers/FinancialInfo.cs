namespace Api.Helpers;

public class FinancialInfo : BaseModel
{
    public required string PatientType { get; set; }
    public string? CompanyNo { get; set; }
    public string? PatientClass { get; set; }
    public double DebtSet { get; set; }
    public double Discount { get; set; } 
    public string? InsuranceAccount { get; set; }
    public DateTime InsuranceExp { get; set; }
    public string? Notes { get; set; }
    public double InitialCredit { get; set; }
    public double CurrenctCredit { get; set; }
}