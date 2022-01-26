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
    public class IndexModel : PageModel
    {
        private readonly TrophyCaseProject.Data.TrophyCaseProjectContext _context;

        public IndexModel(TrophyCaseProject.Data.TrophyCaseProjectContext context)
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
