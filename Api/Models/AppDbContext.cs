using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api;
public partial class AppDbContext : DbContext
{
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }  = null!;
        public DbSet<MedicalFile> MedicalFiles { get; set; }  = null!;
        public DbSet<TreatmentHistory> TreatmentsHistory { get; set; }  = null!;
        public DbSet<Attachment> Attachments { get; set; }  = null!;
        public DbSet<Examination> Examinations { get; set; }  = null!;
}