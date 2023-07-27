using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Pages.Models;

namespace MyPortfolio.Pages.Shared
{
    public class _PortfolioProjectModel : PageModel
    {
        public string HtmlId { get; set; }
        public PortfolioProject Project { get; set; }

        public PortfolioProjectOverlay ProjectOverlay { get; set; }

        public _PortfolioProjectModel(string htmlId, PortfolioProject project, PortfolioProjectOverlay projectOverlay)
        {
            HtmlId = htmlId;
            Project = project;
            ProjectOverlay = projectOverlay;
        }
        public void OnGet()
        {
        }
    }
}
