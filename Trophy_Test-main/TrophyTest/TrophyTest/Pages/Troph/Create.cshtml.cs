#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrophyTest.Data;
using TrophyTest.Models;

namespace TrophyTest.Pages.Troph
{
    public class CreateModel : PageModel
    {
        private readonly TrophyTest.Data.TrophyTestContext _context;

        public CreateModel(TrophyTest.Data.TrophyTestContext context)
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
