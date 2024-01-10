using Api.Helpers;

namespace Api.Models;

public class MedicalFile : BaseModel
{
    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;
    public required string BloodType { get; set; }
    public string? BloodPressure { get; set; }
    public double HeatDgree { get; set; }
    public int PulseRate { get; set; }
    public int SugarLevel { get; set; }
    public int Weight { get; set; }
    public int Hieght { get; set; }
    public ICollection<string>? Allergies { get; set; }
    public string? Notes { get; set; }
    public ICollection<TreatmentHistory>? TreatmentHistory { get; set; }
}