using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _ProjectInfoModel : PageModel
    {
        public string Description { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Users { get; set; }
        public string Client { get; set; }
        public string Sector { get; set; }
        public string MyInvolvement { get; set; }
        public List<string> URLs { get; set; }

        public _ProjectInfoModel(string description, string from, string to, string users, string client, string sector, string myInvolvement, List<string> urls)
        {
            Description = description;
            From = from;
            To = to;
            Users = users;
            Client = client;
            Sector = sector;
            MyInvolvement = myInvolvement;
            URLs = urls;
        }

        public void OnGet()
        {
        }
    }
}
