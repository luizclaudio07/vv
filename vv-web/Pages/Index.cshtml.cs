using Microsoft.AspNetCore.Mvc.RazorPages;

namespace vv_web.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData.Add("blabla", "Alo");
        }
    }
}
