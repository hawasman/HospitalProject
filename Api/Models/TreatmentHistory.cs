using Api.Helpers;

namespace Api.Models;

public class TreatmentHistory : BaseModel
{
    public required string Type { get; set; }
    public int DoctorId { get; set; }
    public int Clinicid { get; set; }
    public required string Symptoms { get; set; }
    public List<string>? Examinations { get; set; }
    public List<string>? Analysis { get; set; }
    public required string Diagnosis { get; set; }
    public List<string>? Treatment { get; set; }
    public List<string>? Services { get; set; }

    public int MedicalFileId { get; set; }
    public MedicalFile MedicalFile { get; set; } = null!;
}