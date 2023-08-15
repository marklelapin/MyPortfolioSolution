using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _ModalSimpleModel : PageModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }

        //public bool IsStatic { get; set; } = false; TODO -add in at later date to allow for static modal

        public string ButtonText { get; set; } = "Ok";

        public string ButtonType { get; set; } = "primary";

        public _ModalSimpleModel(string id, string title, string message, string? buttonText = null, string? buttonType = null)
        {
            Id = id;
            Title = title;
            Message = message;
            if (buttonText != null) ButtonText = buttonText;
            if (buttonType != null) { ButtonType = buttonType; };
        }
        public void OnGet()
        {
        }

    }
}
