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
    public class DetailsModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public DetailsModel(WebUniversity.Data.WebUniversityContext context)
        {
            _context = context;
        }

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
    }
}
