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
    public class TeacherStudyJointsController : ControllerBase
    {
        private readonly WebUniversityContext _context;

        public TeacherStudyJointsController(WebUniversityContext context)
        {
            _context = context;
        }

        // GET: api/TeacherStudyJoints
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherStudyJoint>>> GetTeacherStudyJoint()
        {
            return await _context.TeacherStudyJoint.ToListAsync();
        }

        // GET: api/TeacherStudyJoints/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherStudyJoint>> GetTeacherStudyJoint(long id)
        {
            var teacherStudyJoint = await _context.TeacherStudyJoint.FindAsync(id);

            if (teacherStudyJoint == null)
            {
                return NotFound();
            }

            return teacherStudyJoint;
        }

        // PUT: api/TeacherStudyJoints/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacherStudyJoint(long id, TeacherStudyJoint teacherStudyJoint)
        {
            if (id != teacherStudyJoint.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacherStudyJoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherStudyJointExists(id))
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

        // POST: api/TeacherStudyJoints
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TeacherStudyJoint>> PostTeacherStudyJoint(TeacherStudyJoint teacherStudyJoint)
        {
            _context.TeacherStudyJoint.Add(teacherStudyJoint);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacherStudyJoint", new { id = teacherStudyJoint.Id }, teacherStudyJoint);
        }

        // DELETE: api/TeacherStudyJoints/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeacherStudyJoint>> DeleteTeacherStudyJoint(long id)
        {
            var teacherStudyJoint = await _context.TeacherStudyJoint.FindAsync(id);
            if (teacherStudyJoint == null)
            {
                return NotFound();
            }

            _context.TeacherStudyJoint.Remove(teacherStudyJoint);
            await _context.SaveChangesAsync();

            return teacherStudyJoint;
        }

        private bool TeacherStudyJointExists(long id)
        {
            return _context.TeacherStudyJoint.Any(e => e.Id == id);
        }
    }
}
