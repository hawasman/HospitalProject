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
    public class MedicalFilesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MedicalFilesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MedicalFiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicalFile>>> GetMedicalFiles()
        {
            return await _context.MedicalFiles.ToListAsync();
        }

        // GET: api/MedicalFiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicalFile>> GetMedicalFile(int id)
        {
            var medicalFile = await _context.MedicalFiles.FindAsync(id);

            if (medicalFile == null)
            {
                return NotFound();
            }

            return medicalFile;
        }

        [HttpGet("patient/{id}")]
        public async Task<ActionResult<MedicalFile>> GetMedicalFileByPatientId(int id)
        {
            try
            {
                var medicalFile = await _context.MedicalFiles.FirstOrDefaultAsync(m => m.PatientId == id);
                if (medicalFile == null)
                {
                    return NotFound();
                }

                return Ok(medicalFile);
            }
            catch (System.Exception)
            {
                return NotFound();
            }

        }

        // PUT: api/MedicalFiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicalFile(int id, MedicalFile medicalFile)
        {
            if (id != medicalFile.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicalFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalFileExists(id))
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

        // POST: api/MedicalFiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MedicalFile>> PostMedicalFile(MedicalFile medicalFile)
        {
            _context.MedicalFiles.Add(medicalFile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicalFile", new { id = medicalFile.Id }, medicalFile);
        }

        // DELETE: api/MedicalFiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicalFile(int id)
        {
            var medicalFile = await _context.MedicalFiles.FindAsync(id);
            if (medicalFile == null)
            {
                return NotFound();
            }

            _context.MedicalFiles.Remove(medicalFile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicalFileExists(int id)
        {
            return _context.MedicalFiles.Any(e => e.Id == id);
        }
    }
}
