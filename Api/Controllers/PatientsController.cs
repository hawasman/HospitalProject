using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController(EFService<Patient> service, EFService<ContactInfo> contactInfoService) : BaseController<Patient>(service)
    {
        [HttpGet("{id}")]
        public override async Task<ActionResult<Patient?>> GetById(int id)
        {
            var entity = await _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }

            entity.ContactInfo = await contactInfoService.GetById(entity.ContactInfoId ?? 0);
            return entity;
        }
    }

}
