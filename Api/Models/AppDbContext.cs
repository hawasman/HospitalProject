using System.Linq.Expressions;
using Api.Helpers;
using Api.Models;
using Api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Api;

public partial class AppDbContext : DbContext
{
    private readonly ITenant _tenant;
    private readonly ITenantService _tenantService;

    public AppDbContext(DbContextOptions<AppDbContext> options, ITenantService tenantService) : base(options)
    {
        _tenantService = tenantService;
        _tenant = tenantService.GetTenant();
    }

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
        var tenantConnectionString = _tenantService.GetConnectionString();
        if (!string.IsNullOrEmpty(tenantConnectionString))
        {
            var DBProvider = _tenantService.GetDatabaseProvider();
            if (DBProvider?.ToLower() == "postegresql")
            {
                options.UseNpgsql(_tenantService.GetConnectionString());

            }
        }

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // define your filter expression tree
        Expression<Func<ITenantModel, bool>> filterExpr = b => b.TenantId == _tenant.TID;
        foreach (var mutableEntityType in modelBuilder.Model.GetEntityTypes())
        {
            // check if current entity type is child of BaseModel
            if (mutableEntityType.ClrType.IsAssignableTo(typeof(ITenantModel)))
            {
                // modify expression to handle correct child type
                var parameter = Expression.Parameter(mutableEntityType.ClrType);
                var body = ReplacingExpressionVisitor.Replace(filterExpr.Parameters.First(), parameter, filterExpr.Body);
                var lambdaExpression = Expression.Lambda(body, parameter);

                // set filter
                mutableEntityType.SetQueryFilter(lambdaExpression);
            }
        }
        FakeData.Init(100);
        modelBuilder.Entity<ContactInfo>().HasData(FakeData.ContactInfos);
        modelBuilder.Entity<Patient>().HasData(FakeData.Patients);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<ITenantModel>().ToList())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                case EntityState.Modified:
                    entry.Entity.TenantId = _tenant.TID;
                    break;
            }
        }
        var result = await base.SaveChangesAsync(cancellationToken);
        return result;
    }
}