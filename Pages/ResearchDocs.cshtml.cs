using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactCenter.Pages
{
    public class ResearchDocsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ResearchDocsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}