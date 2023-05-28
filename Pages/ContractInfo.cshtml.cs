using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactCenter.Pages
{
    public class ContractInfoModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ContractInfoModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}