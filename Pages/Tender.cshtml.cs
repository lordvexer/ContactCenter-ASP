using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactCenter.Pages
{
    public class TenderModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public TenderModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}