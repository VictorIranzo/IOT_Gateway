namespace HealthAndWelfare.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using HealthAndWelfare.Persistence;

    [Route("Treatments")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private readonly Context _context;

        public TreatmentController(Context context)
        {
            _context = context;
        }

        // GET: api/Treatment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Treatment>>> GetTreatments()
        {
            return await _context.Treatments.ToListAsync();
        }

        // GET: api/Treatment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Treatment>> GetTreatment(Guid id)
        {
            var treatment = await _context.Treatments.FindAsync(id);

            if (treatment == null)
            {
                return NotFound();
            }

            return treatment;
        }

        // PUT: api/Treatment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTreatment(Guid id, Treatment treatment)
        {
            if (id != treatment.Id)
            {
                return BadRequest();
            }

            _context.Entry(treatment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreatmentExists(id))
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

        // POST: api/Treatment
        [HttpPost]
        public async Task<ActionResult<Treatment>> PostTreatment(Treatment treatment)
        {
            _context.Treatments.Add(treatment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTreatment", new { id = treatment.Id }, treatment);
        }

        // DELETE: api/Treatment/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Treatment>> DeleteTreatment(Guid id)
        {
            var treatment = await _context.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return NotFound();
            }

            _context.Treatments.Remove(treatment);
            await _context.SaveChangesAsync();

            return treatment;
        }

        private bool TreatmentExists(Guid id)
        {
            return _context.Treatments.Any(e => e.Id == id);
        }
    }
}
