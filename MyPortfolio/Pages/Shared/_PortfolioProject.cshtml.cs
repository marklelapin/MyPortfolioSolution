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
        public string? SeeMoreLink { get; set; } = null;
        public string? SeeItInActionLink { get; set; } = null;  

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


        public _PortfolioProjectModel AddSeeMoreLink()
        {
           SeeMoreLink = "project-details";
            return this;
        }

        public _PortfolioProjectModel AddSeeItInActionLink(string link)
        {
            SeeItInActionLink = link;
            return this;
        }

        public _PortfolioProjectModel Build()
        {
            return this;
        }

        public string ActionOnClick()
        {
            if (Link == null) {
                return "open-modal-on-click";
            } 
            return "go-to-link-on-click";
        }   
    }
}
