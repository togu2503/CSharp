using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebUniversity;
using WebUniversity.Data;

namespace WebUniversity.Pages.Teachers
{
    public class DeleteModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public DeleteModel(WebUniversity.Data.WebUniversityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teacher
                .Include(t => t.Post).FirstOrDefaultAsync(m => m.Id == id);

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teacher.FindAsync(id);

            if (Teacher != null)
            {
                _context.Teacher.Remove(Teacher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
