using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _SectionHeadingModel : PageModel
    {
        public string Title { get; set; }

        public string SectionTitle { get; set; }

        public string MarginTop { get; set; } = "1";

        public string MarginBottom { get; set; } = "1";

        public string HighlightColor { get; set; } = "blue";

        public string Background { get; set; } = "dark";

        public _SectionHeadingModel(string sectionTitle, string title, string highlightColor, string background, int? marginTop = null, int? marginBottom = null)
        {
            SectionTitle = sectionTitle;
            Title = title;
            HighlightColor = highlightColor;
            Background = background;
            if (marginTop != null) { MarginTop = marginTop.ToString()!; }
            if (marginTop != null) { MarginTop = marginBottom.ToString()!; }
        }
        public void OnGet()
        {
        }

        public string SectionTitleClasses()
        {
            string sharedClasses = "text-24 text-uppercase fw-600 w-100 mb-0";
            string darkClass = "text-white-50 opacity-1";
            string lightClass = "opacity-2";

            if (Background == "dark")
            {
                return sharedClasses + " " + darkClass;
            }
            else
            {
                return sharedClasses + " " + lightClass;
            }

        }

        public string TitleClasses()
        {

            string sharedClasses = $"text-9 fw-600 position-absolute w-100 align-self-center lh-base mb-0";
            string darkClass = "text-white";
            string lightClass = "";

            if (Background == "dark")
            {
                return $"{sharedClasses} {darkClass}";
            }
            else
            {
                return $"{sharedClasses} {lightClass}";
            }

        }

        public string UnderLineClasses()
        {
            return $"heading-separator-line border-bottom border-3 {HighlightColor} d-block mx-auto";
        }
    }
}