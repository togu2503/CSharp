﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebUniversity;
using WebUniversity.Data;

namespace WebUniversity.Pages.Teachers
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
        ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Teacher Teacher { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Teacher.Add(Teacher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
