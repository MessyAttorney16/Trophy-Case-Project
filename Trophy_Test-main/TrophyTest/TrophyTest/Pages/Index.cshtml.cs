using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrophyTest.Services;
using Microsoft.Extensions.Logging;
using TrophyTest.Models;

namespace TrophyTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileTrophyService TrophyService;
        public IEnumerable<Trophy> Trophies { get; set; }



        public IndexModel(ILogger<IndexModel> logger,
            JsonFileTrophyService jsonFileTrophyService)
        
        
        
        {
            _logger = logger;
            TrophyService = jsonFileTrophyService;
        }

        public void OnGet()
        {
            Trophies = TrophyService.GetTrophys();
        }
    }
}