using Api.Helpers;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api;

public partial class AppDbContext(DbContextOptions<AppDbContext> options, ITenant tenant) : DbContext(options)
{
    private readonly ITenant _tenant = tenant;

    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<MedicalFile> MedicalFiles { get; set; } = null!;
    public DbSet<TreatmentHistory> TreatmentsHistory { get; set; } = null!;
    public DbSet<Attachment> Attachments { get; set; } = null!;
    public DbSet<Examination> Examinations { get; set; } = null!;
    public DbSet<ContactInfo> ContactInfos { get; set; } = null!;
    public DbSet<FinancialInfo> FinancialInfos { get; set; } = null!;
    public DbSet<Tenant> Tenants { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.EnableSensitiveDataLogging();
        
    }
    

    //TODO: Fix Tenancy id update
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.Entity<BaseModel>().HasQueryFilter(b => b.TenantId == _tenant.Id);
        FakeData.Init(100);
        modelBuilder.Entity<ContactInfo>().HasData(FakeData.ContactInfos);
        modelBuilder.Entity<Patient>().HasData(FakeData.Patients);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // foreach (var entity in ChangeTracker.Entries<BaseModel>())
        // {
        //     if(entity.State == EntityState.Added){
        //         entity.Entity.TenantId = _tenant.Id;
        //     }
        // }
        return base.SaveChangesAsync(cancellationToken);
    }
}