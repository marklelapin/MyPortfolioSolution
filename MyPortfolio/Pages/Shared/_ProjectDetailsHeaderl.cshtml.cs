using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _ProjectDetailsHeaderModel : PageModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public _ProjectDetailsHeaderModel(string title, string subTitle)
        {
            Title = title;
            SubTitle = subTitle;
        }
        public void OnGet()
        {
        }
    }
}
