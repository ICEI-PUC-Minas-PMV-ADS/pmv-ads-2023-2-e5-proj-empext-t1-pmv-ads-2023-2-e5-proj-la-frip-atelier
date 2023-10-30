using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrechoLaFripAtelier.Pages.Admins
{
    public class LogoutModel : PageModel
    {
        public async Task<PageResult> OnGetAsync()
        {
            await HttpContext.SignOutAsync();

            return Page();
        }
    }
}
