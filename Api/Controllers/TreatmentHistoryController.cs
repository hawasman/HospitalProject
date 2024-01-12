using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentHistoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TreatmentHistoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/TreatmentHistory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TreatmentHistory>>> GetTreatmentsHistory()
        {
            return await _context.TreatmentsHistory.ToListAsync();
        }

        // GET: api/TreatmentHistory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TreatmentHistory>> GetTreatmentHistory(int id)
        {
            var treatmentHistory = await _context.TreatmentsHistory.FindAsync(id);

            if (treatmentHistory == null)
            {
                return NotFound();
            }

            return treatmentHistory;
        }

         [HttpGet("medicalFile/{id}")]
        public async Task<ActionResult<List<TreatmentHistory>>> GetTreatmentHistoryByMedicalFileid(int id)
        {
            var treatmentHistory = await _context.TreatmentsHistory.Where(t => t.MedicalFileId == id).ToListAsync();

            if (treatmentHistory == null)
            {
                return NotFound();
            }

            return treatmentHistory;
        }

        // PUT: api/TreatmentHistory/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTreatmentHistory(int id, TreatmentHistory treatmentHistory)
        {
            if (id != treatmentHistory.Id)
            {
                return BadRequest();
            }

            _context.Entry(treatmentHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreatmentHistoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TreatmentHistory
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TreatmentHistory>> PostTreatmentHistory(TreatmentHistory treatmentHistory)
        {
            _context.TreatmentsHistory.Add(treatmentHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTreatmentHistory", new { id = treatmentHistory.Id }, treatmentHistory);
        }

        // DELETE: api/TreatmentHistory/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTreatmentHistory(int id)
        {
            var treatmentHistory = await _context.TreatmentsHistory.FindAsync(id);
            if (treatmentHistory == null)
            {
                return NotFound();
            }

            _context.TreatmentsHistory.Remove(treatmentHistory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TreatmentHistoryExists(int id)
        {
            return _context.TreatmentsHistory.Any(e => e.Id == id);
        }
    }
}
