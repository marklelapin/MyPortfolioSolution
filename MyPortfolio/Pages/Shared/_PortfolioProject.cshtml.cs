using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Pages.Models;

namespace MyPortfolio.Pages.Shared
{
    public class _PortfolioProjectModel : PageModel
    {
        public string HtmlId { get; set; }
        public PortfolioProject Project { get; set; }

        public PortfolioProjectOverlay ProjectOverlay { get; set; }

        public string? Link { get; set; } = null;
        public string? ActionLink { get; set; } = null;
        public string? ActionButtonText { get; set; } = null;

        public _PortfolioProjectModel(string htmlId, PortfolioProject project, PortfolioProjectOverlay projectOverlay, string? link = null)
        {
            HtmlId = htmlId;
            Project = project;
            ProjectOverlay = projectOverlay;
            Link = link;
        }
        public void OnGet()
        {
        }


        public void AddActionLink( string actionLink, string actionButtonText)
        {
            ActionLink = actionLink;
            ActionButtonText = actionButtonText;
        }

        public _PortfolioProjectModel Build()
        {
            return this;
        }

        public string OpenModalOnClick()
        {
            if (Link == null) {
                return "open-modal-on-click";
            }
            return "";
        }   
    }
}
