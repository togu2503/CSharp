using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebUniversity;
using WebUniversity.Data;

namespace WebUniversity.Pages.Studies
{
    public class DeleteModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public DeleteModel(WebUniversity.Data.WebUniversityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Study Study { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Study = await _context.Study.FirstOrDefaultAsync(m => m.Id == id);

            if (Study == null)
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

            Study = await _context.Study.FindAsync(id);

            if (Study != null)
            {
                _context.Study.Remove(Study);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
