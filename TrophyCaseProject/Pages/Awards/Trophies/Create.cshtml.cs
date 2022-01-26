#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrophyCaseProject.Data;
using TrophyCaseProject.Models;

namespace TrophyCaseProject.Pages.Awards.Trophies
{
    public class CreateModel : PageModel
    {
        private readonly TrophyCaseProject.Data.TrophyCaseProjectContext _context;

        public CreateModel(TrophyCaseProject.Data.TrophyCaseProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Trophy Trophy { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trophy.Add(Trophy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
