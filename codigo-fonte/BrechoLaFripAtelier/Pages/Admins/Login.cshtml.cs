using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BrechoLaFripAtelier.Pages.Admins
{
    public class LoginModel : PageModel
    {
        private readonly MyDbContext _context;

        public LoginModel(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        
        [BindProperty]
        public Admin Admin { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            var adminLogin = await _context.Admins.FirstOrDefaultAsync(m => m.Username == Admin.Username);

            if (adminLogin == null)
            {
                TempData["Message"] = "Informe o usuário e a senha";
            }
            else
            {
                bool passwordOk = BCrypt.Net.BCrypt.Verify(Admin.Password, adminLogin.Password);

                if (passwordOk)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, adminLogin.Name),
                        new Claim(ClaimTypes.NameIdentifier, adminLogin.Id.ToString()),
                        new Claim("Username", adminLogin.Username)
                    };

                    var userIdentity = new ClaimsIdentity(claims, "login");

                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    var props = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                        IsPersistent = true
                    };

                    await HttpContext.SignInAsync(principal, props);

                    return Redirect("/");
                }
                else
                {
                    TempData["Message"] = "Usuário e/ou senha inválidos";
                }
            }

            return Page();
        }
    }
}
