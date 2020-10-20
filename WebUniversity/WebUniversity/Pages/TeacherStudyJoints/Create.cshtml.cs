using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebUniversity;
using WebUniversity.Data;

namespace WebUniversity.Pages.TeacherStudyJoints
{
    public class CreateModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public CreateModel(WebUniversity.Data.WebUniversityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Id");
        ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public TeacherStudyJoint TeacherStudyJoint { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TeacherStudyJoint.Add(TeacherStudyJoint);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
