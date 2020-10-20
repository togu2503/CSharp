using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebUniversity;
using WebUniversity.Data;

namespace WebUniversity.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebUniversity.Data.WebUniversityContext _context;

        public IndexModel(WebUniversity.Data.WebUniversityContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
}
