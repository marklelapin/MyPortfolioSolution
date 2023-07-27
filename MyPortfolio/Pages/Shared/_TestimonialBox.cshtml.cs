using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _TestimonialBoxModel : PageModel
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Quote { get; set; }
        public string ImageSource { get; set; }

        public _TestimonialBoxModel(string name, string jobTitle, string quote, string imageSource)
        {
            Name = name;
            JobTitle = jobTitle;
            Quote = quote;
            ImageSource = imageSource;
        }
        public void OnGet()
        {
        }
    }
}
