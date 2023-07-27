using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _SectionHeadingModel : PageModel
    {
        public string Title { get; set; }

        public string SectionTitle { get; set; }

        public string MarginTop { get; set; } = "1";

        public string MarginBottom { get; set; } = "1";

        public _SectionHeadingModel(string sectionTitle, string title, int? marginTop = null, int? marginBottom = null)
        {
            SectionTitle = sectionTitle;
            Title = title;
            if (marginTop != null) { MarginTop = marginTop.ToString()!; }
            if (marginTop != null) { MarginTop = marginBottom.ToString()!; }
        }
        public void OnGet()
        {
        }
    }
}
