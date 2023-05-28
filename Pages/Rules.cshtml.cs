using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactCenter.Pages
{
    public class RulesModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public RulesModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}