using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentHistoryController(EFService<TreatmentHistory> service) : BaseController<TreatmentHistory>(service)
    {
    }
    
}
