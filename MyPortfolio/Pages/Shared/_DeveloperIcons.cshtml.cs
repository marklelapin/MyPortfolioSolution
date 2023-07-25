using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages.Shared
{
    public class _DeveloperIconsModel : PageModel
    {
        public List<List<string>> GroupedIcons { get; set; }


        public _DeveloperIconsModel(string[] icons)
        {
            GroupedIcons = GroupIcons(icons.ToList());
        }

        public _DeveloperIconsModel(List<string> icons)
        {
            GroupedIcons = GroupIcons(icons);
        }


        private List<List<string>> GroupIcons(List<string> icons)
        {
            List<List<string>> output = new List<List<string>>();

            List<string> list = new List<string>();

            foreach (var icon in icons)
            {
                if (icon != "gap")
                {
                    list.Add(icon);
                }
                else
                {
                    AddListToGroups(list, output);

                    list.Clear();
                }


            }

            AddListToGroups(list, output);

            return output;
        }


        private void AddListToGroups(List<string> list, List<List<string>> groups)
        {
            groups.Add(new List<string>());

            foreach (var icon in list)
            {
                groups[groups.Count - 1].Add(icon);
            }
        }




        public void OnGet()
        {

        }
    }
}
