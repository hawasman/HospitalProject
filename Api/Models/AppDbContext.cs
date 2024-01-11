using Api.Helpers;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<MedicalFile> MedicalFiles { get; set; } = null!;
    public DbSet<TreatmentHistory> TreatmentsHistory { get; set; } = null!;
    public DbSet<Attachment> Attachments { get; set; } = null!;
    public DbSet<Examination> Examinations { get; set; } = null!;
    public DbSet<ContactInfo> ContactInfos { get; set; } = null!;
    public DbSet<FinancialInfo> FinancialInfos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.EnableSensitiveDataLogging();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        FakeData.Init(100);
        modelBuilder.Entity<ContactInfo>().HasData(FakeData.ContactInfos);
        modelBuilder.Entity<Patient>().HasData(FakeData.Patients);
    }
}