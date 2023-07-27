using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Pages.Shared;

namespace MyPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public _ContactModel? ContactModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public PartialViewResult OnGetPopupContent(string viewName)
        {
            var output = Partial(viewName);
            return output;
        }
    }
}