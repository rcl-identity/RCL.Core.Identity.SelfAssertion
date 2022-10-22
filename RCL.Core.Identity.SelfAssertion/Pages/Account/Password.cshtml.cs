using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RCL.Core.Identity.SelfAssertion.Pages.Account
{
    [Authorize]
    public class PasswordModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
