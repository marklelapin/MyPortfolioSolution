using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Pages.Models;

namespace MyPortfolio.Pages.Shared
{

    public class _ContactModel : PageModel
    {

        public Contact Contact { get; set; }

        public _ContactModel(Contact contact)
        {
            Contact = contact;
        }

        public void OnGet()
        {
            Contact = new Contact();
        }

        public void OnPost()
        {

        }
    }
}
