namespace MyPortfolio.Pages.Models
{
    public class PortfolioProjectOverlay
    {
        public string AppTitle { get; set; }

        public List<string> AppDescription { get; set; }

        public List<string> DeveloperIcons { get; set; }

        public string AjaxProjectPartial { get; set; }

        public PortfolioProjectOverlay(string appTitle, List<string> appDescription, List<string> developerIcons, string ajaxProjectPartial)
        {
            AppTitle = appTitle;
            AppDescription = appDescription;
            DeveloperIcons = developerIcons;
            AjaxProjectPartial = ajaxProjectPartial;

        }
    }
}
