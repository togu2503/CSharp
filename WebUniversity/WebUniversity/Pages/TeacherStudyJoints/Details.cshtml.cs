using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebUniversity;
using WebUniversity.Data;

namespace WebUniversity.Pages.TeacherStudyJoints
{
    public class DetailsModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public DetailsModel(WebUniversity.Data.WebUniversityContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
