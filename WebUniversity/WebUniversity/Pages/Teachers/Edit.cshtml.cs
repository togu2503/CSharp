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

namespace WebUniversity.Pages.Teachers
{
    public class EditModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public EditModel(WebUniversity.Data.WebUniversityContext context)
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
           ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
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

            _context.Attach(Teacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(Teacher.Id))
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

        private bool TeacherExists(long id)
        {
            return _context.Teacher.Any(e => e.Id == id);
        }
    }
}
