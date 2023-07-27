using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _SkillBoxModel : PageModel
    {
        public string FontAwesomeIcon { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }

        public _SkillBoxModel(string fontAwesomeIcon, string title, string text)
        {
            FontAwesomeIcon = fontAwesomeIcon;
            Title = title;
            Text = text;
        }
        public void OnGet()
        {
        }
    }
}
