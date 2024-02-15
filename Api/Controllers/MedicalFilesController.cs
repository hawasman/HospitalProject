using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalFilesController(EFService<MedicalFile> service) : BaseController<MedicalFile>(service)
    {
        [HttpGet("patient/{id}")]
        public ActionResult<MedicalFile> GetMedicalFileByPatientId(int id)
        {

            var medicalFile = _service.Where(m => m.PatientId == id).FirstOrDefault();
            if (medicalFile == null)
            {
                return NotFound();
            }

            return Ok(medicalFile);


        }
    }

}
