using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController(EFService<Patient> service, EFService<ContactInfo> contactInfoService, EFService<MedicalFile> medicalFileService) : BaseController<Patient>(service)
    {

        public override async Task<ActionResult<Patient>> Create(Patient entity)
        {
            var medicalFile = await medicalFileService.Create(new MedicalFile
            {
                BloodType = "none",
            });
            entity.MedicalFileId = medicalFile.Id;
            return await base.Create(entity);
        }

        [HttpGet("{id}")]
        public override async Task<ActionResult<Patient?>> GetById(int id)
        {
            var entity = await _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }

            entity.ContactInfo = await contactInfoService.GetById(entity.ContactInfoId ?? 0);
            entity.MedicalFile = await medicalFileService.GetById(entity.MedicalFileId ?? 0);
            return entity;
        }
    }

}
