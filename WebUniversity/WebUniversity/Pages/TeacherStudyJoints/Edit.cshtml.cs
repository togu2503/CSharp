using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUniversity;
using WebUniversity.Data;

namespace WebUniversity.Pages.TeacherStudyJoints
{
    public class EditModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public EditModel(WebUniversity.Data.WebUniversityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TeacherStudyJoint TeacherStudyJoint { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TeacherStudyJoint = await _context.TeacherStudyJoint
                .Include(t => t.Study)
                .Include(t => t.Teacher).FirstOrDefaultAsync(m => m.Id == id);

            if (TeacherStudyJoint == null)
            {
                return NotFound();
            }
           ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Id");
           ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TeacherStudyJoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherStudyJointExists(TeacherStudyJoint.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TeacherStudyJointExists(long id)
        {
            return _context.TeacherStudyJoint.Any(e => e.Id == id);
        }
    }
}
