using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Pages.Models
{
    public class Contact
    {

        public string? Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        public string? Message { get; set; }

    }
}
