using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyClassLibrary.Methods;
using MyPortfolio.Pages.Models;

namespace MyPortfolio.Pages.Shared
{

    public class _ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public string EmailConfirmationMessage { get; set; }

        private IConfiguration _configuration { get; set; }

        public _ContactModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnPost()
        {
            var emailClient = new EmailClient(_configuration);

            try
            {
                emailClient.Send($"{Contact.Email}", "magcarter@hotmail.co.uk", $"Portfolio Enquiry from {Contact.Name}", $"{Contact.Message}");
            }
            catch
            {
                EmailConfirmationMessage = "Sorry. Something went wrong sending the email. Please try contacting me directly on magcarter@hotmail.co.uk";
                return;
            }

            EmailConfirmationMessage = "Thanks for you message. I'll respond as soon as I can.";

        }
    }
}
