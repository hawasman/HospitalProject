using System.Linq.Expressions;
using Api.Helpers;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // define your filter expression tree
        Expression<Func<BaseModel, bool>> filterExpr = b => b.TenantId == _tenant.Id;
        foreach (var mutableEntityType in modelBuilder.Model.GetEntityTypes())
        {
            // check if current entity type is child of BaseModel
            if (mutableEntityType.ClrType.IsAssignableTo(typeof(BaseModel)))
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
}