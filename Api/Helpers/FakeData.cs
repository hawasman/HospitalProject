using Api.Models;
using Bogus;

namespace Api.Helpers;

public static class FakeData
{
    public static List<ContactInfo> ContactInfos = [];
    public static List<Patient> Patients = [];
    private static int _patientId = 1;
    private static int _contactInfoId = 1;


    public static void Init(int count)
    {
        var contactInfoFaker = new Faker<ContactInfo>("ar")
            .RuleFor(c => c.Id, f => _contactInfoId++)
            .RuleFor(p => p.CreatedAt , f => f.Date.Recent())
            .RuleFor(p => p.UpdatedAt , f => f.Date.Recent())
            .RuleFor(p => p.UserId , f => 1)
            .RuleFor(p => p.ActiveField , f => true)
            .RuleFor(c => c.Phone1, f => f.Person.Phone)
            .RuleFor(c => c.Email, f => f.Person.Email)
            .RuleFor(c => c.Address, f => f.Address.FullAddress())
            .RuleFor(c => c.City, f => f.Address.City());
        
        var patientFaker = new Faker<Patient>("ar")
            .RuleFor(p => p.Id, f => _patientId++)
            .RuleFor(p => p.CreatedAt , f => f.Date.Recent())
            .RuleFor(p => p.UpdatedAt , f =>f.Date.Recent())
            .RuleFor(p => p.UserId , f => 1)
            .RuleFor(p => p.ActiveField , f => true)
            .RuleFor(p => p.FullNameEnglish, f => f.Name["en"].FullName())
            .RuleFor(p => p.FullNameArabic, f => f.Person.FullName)
            .RuleFor(p => p.BirthDate, f => f.Person.DateOfBirth)
            .RuleFor(p => p.Nationality, f => f.Address.Country())
            .RuleFor(p => p.Gender, f => f.PickRandom<Gender>())
            .RuleFor(p => p.SocialState, f => f.PickRandom<SocialState>())
            .RuleFor(p => p.Religion, f => "مسلم")
            .RuleFor(p => p.NationalId, f => f.Random.Long(1).ToString())
            .RuleFor(p => p.Job, f => f.Person.Company.Name);
            // .RuleFor(p => p.ContactInfo, f => contactInfoFaker.Generate());

        var contacts = contactInfoFaker.Generate(count);
        FakeData.ContactInfos.AddRange(contacts);
        
        var patients = patientFaker.Generate(count);
        FakeData.Patients.AddRange(patients);
    }
}