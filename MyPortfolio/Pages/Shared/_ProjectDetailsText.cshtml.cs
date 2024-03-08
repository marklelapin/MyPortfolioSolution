using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _ProjectDetailsTextModel : PageModel
    {
        public List<string> Brief { get; set; } = new();
        public List<string> Client { get; set; } = new();
        public List<string> Solution { get; set; } = new();
        public List<string> Adoption { get; set; } = new();
        public List<string> MyInvolvement { get; set; } = new();


        public _ProjectDetailsTextModel()
        {
        }
        public void OnGet()
        {
        }

        public _ProjectDetailsTextModel AddBrief(string brief)
        {
            Brief.Add(brief);
            return this;
        }

        public _ProjectDetailsTextModel AddClient(string client)
        {
            Client.Add(client);
            return this;
        }

        public _ProjectDetailsTextModel AddSolution(string solution)
        {
            Solution.Add(solution);
            return this;
        }

        public _ProjectDetailsTextModel AddAdoption(string adoption)
        {
            Adoption.Add(adoption);
            return this;
        }

        public _ProjectDetailsTextModel AddMyInvolvement(string myInvolvement)
        {
            MyInvolvement.Add(myInvolvement);
            return this;
        }

    }
}
