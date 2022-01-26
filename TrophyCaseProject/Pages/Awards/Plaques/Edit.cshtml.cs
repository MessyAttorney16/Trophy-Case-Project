#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrophyCaseProject.Data;
using TrophyCaseProject.Models;

namespace TrophyCaseProject.Pages.Awards.Plaques
{
    public class EditModel : PageModel
    {
        private readonly TrophyCaseProject.Data.TrophyCaseProjectContext _context;

        public EditModel(TrophyCaseProject.Data.TrophyCaseProjectContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Trophy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrophyExists(Trophy.Id))
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

        private bool TrophyExists(int id)
        {
            return _context.Trophy.Any(e => e.Id == id);
        }
    }
}
