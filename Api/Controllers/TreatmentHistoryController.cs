using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentHistoryController(EFService<TreatmentHistory> service) : BaseController<TreatmentHistory>(service)
    {
        private readonly EFService<TreatmentHistory> _service1 = service;

        [HttpGet("medicalFile/{id}")]
        public ActionResult<List<TreatmentHistory>> GetByMedicalFileId(int id)
        {
            var treatments = _service1.Where(t => t.MedicalFileId == id).ToList();

            if (!treatments.Any())
            {
                return NotFound();
            }

            return Ok(treatments);
        }
    }
    
}
