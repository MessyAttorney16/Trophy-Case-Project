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
    public class IndexModel : PageModel
    {
        private readonly TrophyTest.Data.TrophyTestContext _context;

        public IndexModel(TrophyTest.Data.TrophyTestContext context)
        {
            _context = context;
        }

        public IList<Trophy> Trophy { get;set; }

        public async Task OnGetAsync()
        {
            Trophy = await _context.Trophy.ToListAsync();
        }
    }
}
