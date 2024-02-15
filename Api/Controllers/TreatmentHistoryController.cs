using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentHistoryController(EFService<TreatmentHistory> service) : BaseController<TreatmentHistory>(service)
    {
        [HttpGet("medicalFile/{id}")]
        public ActionResult<List<TreatmentHistory>> GetByMedicalFileId(int id)
        {
            var treatments = _service.Where(t => t.MedicalFileId == id).ToList();

            if (treatments.Count == 0)
            {
                return NotFound();
            }

            return Ok(treatments);
        }
    }
    
}
