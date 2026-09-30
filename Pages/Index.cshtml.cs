using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Lab.Pages
{
    public class IndexModel : PageModel
    {
        public string[] Shows = { "Hamlet", "Cabaret", "Fences", "Aida", "The Phantom of the Opera" };
        public int LongTitleCount = 0;

        public void OnGet()
        {
            int i = 0;
            while (i < Shows.Length)
            {
                if (Shows[i].Length > 5)
                {
                    LongTitleCount++;
                }
                i++;
            }
        }
    }
}