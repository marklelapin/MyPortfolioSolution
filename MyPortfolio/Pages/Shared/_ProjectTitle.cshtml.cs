using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _ProjectTitleModel : PageModel
    {
        public string Title { get; set; }

        public _ProjectTitleModel(string title)
        {
            Title = title;
        }
        public void OnGet()
        {
        }
    }


}
