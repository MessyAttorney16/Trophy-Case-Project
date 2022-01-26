#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrophyCaseProject.Data;
using TrophyCaseProject.Models;

namespace TrophyCaseProject.Pages.Awards.Plaques
{
    public class DeleteModel : PageModel
    {
        private readonly TrophyCaseProject.Data.TrophyCaseProjectContext _context;

        public DeleteModel(TrophyCaseProject.Data.TrophyCaseProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Trophy Trophy { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trophy = await _context.Trophy.FirstOrDefaultAsync(m => m.Id == id);

            if (Trophy == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trophy = await _context.Trophy.FindAsync(id);

            if (Trophy != null)
            {
                _context.Trophy.Remove(Trophy);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
