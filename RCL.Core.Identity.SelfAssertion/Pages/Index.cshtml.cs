using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RCL.Core.Identity.SelfAssertion.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (!string.IsNullOrEmpty(User?.Identity?.Name))
            {
                return RedirectToPage("/Account/Profile", new { area = "" });
            }

            return Page();
        }
    }
}