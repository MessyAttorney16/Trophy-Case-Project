#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrophyTest.Data;
using TrophyTest.Models;

namespace TrophyTest.Pages.Troph
{
    public class DetailsModel : PageModel
    {
        private readonly TrophyTest.Data.TrophyTestContext _context;

        public DetailsModel(TrophyTest.Data.TrophyTestContext context)
        {
            _context = context;
        }

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
    }
}
