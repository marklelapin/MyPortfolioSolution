using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _NumberBoxModel : PageModel
    {
        public string Number { get; set; }
        public string Text { get; set; }

        public _NumberBoxModel(string number, string text)
        {
            Number = number;
            Text = text;
        }

        public void OnGet()
        {
        }
    }
}
