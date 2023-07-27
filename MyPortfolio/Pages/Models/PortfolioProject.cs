namespace MyPortfolio.Pages.Models
{
    public class PortfolioProject
    {
        public string ProjectTitle { get; set; }
        public string ImageSource { get; set; }
        public string ImageAlt { get; set; }

        public string Filter { get; set; }


        public PortfolioProject(string projectTitle, string imageSource, string imageAlt, string filter)
        {
            ProjectTitle = projectTitle;
            ImageSource = imageSource;
            ImageAlt = imageAlt;
            Filter = filter;
        }


    }
}
