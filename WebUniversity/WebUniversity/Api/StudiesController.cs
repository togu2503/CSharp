using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUniversity;
using WebUniversity.Models;

namespace WebUniversity.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudiesController : ControllerBase
    {
        private readonly WebUniversityContext _context;

        public StudiesController(WebUniversityContext context)
        {
            _context = context;
        }

        // GET: api/Studies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Study>>> GetStudy()
        {
            return await _context.Study.ToListAsync();
        }

        // GET: api/Studies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Study>> GetStudy(long id)
        {
            var study = await _context.Study.FindAsync(id);

            if (study == null)
            {
                return NotFound();
            }

            return study;
        }

        // PUT: api/Studies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudy(long id, Study study)
        {
            if (id != study.Id)
            {
                return BadRequest();
            }

            _context.Entry(study).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudyExists(id))
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

        // POST: api/Studies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Study>> PostStudy(Study study)
        {
            _context.Study.Add(study);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudy", new { id = study.Id }, study);
        }

        // DELETE: api/Studies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Study>> DeleteStudy(long id)
        {
            var study = await _context.Study.FindAsync(id);
            if (study == null)
            {
                return NotFound();
            }

            _context.Study.Remove(study);
            await _context.SaveChangesAsync();

            return study;
        }

        private bool StudyExists(long id)
        {
            return _context.Study.Any(e => e.Id == id);
        }
    }
}
