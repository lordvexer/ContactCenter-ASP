using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactCenter.Pages
{
    public class BudgetModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public BudgetModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}