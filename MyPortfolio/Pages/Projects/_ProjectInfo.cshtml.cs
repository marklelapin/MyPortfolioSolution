using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Projects
{
    public class _ProjectInfoModel : PageModel
    {
        public string Description { get; set; } = "-";
        public string Problem { get; set; } = "-";
        public string Solution { get; set; } = "-";
        public List<string> MyInvolvement { get; set; } = new List<string>() { "-" };

        public string Users { get; set; } = "-";
        public string Organisation { get; set; } = "-";
        public string From { get; set; } = "-";
        public string To { get; set; } = "-";

        public List<string> Urls { get; set; } = new List<string>() { "Internal Application" };



        public int MyProperty { get; set; }
        public void OnGet()
        {
        }
    }
}
