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

        public bool AdminExist { get; set; }

        public LoginModel(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if (User.Identity.IsAuthenticated) return RedirectToPage("../Index");

            AdminExist = await _context.Admins.AnyAsync();

            return Page();
        }

        [BindProperty]
        public Admin Admin { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (Admin.Username == "admin" && Admin.Password == "abcde123")
            {
                if (!_context.Admins.Any())
                {
                    string vToken = Guid.NewGuid().ToString();

                    HttpContext.Session.SetString("VerificationToken", vToken);

                    return RedirectToPage("./Register", new { vToken });
                }
                else
                {
                    TempData["Message"] = "Usuário e/ou senha inválidos";
                }
            }

            var matchedAdmin = await _context.Admins.FirstOrDefaultAsync(m => m.Username == Admin.Username);

            if (matchedAdmin == null)
            {
                TempData["Message"] = "Usuário e/ou senha inválidos";
            }
            else
            {
                bool passwordOk = BCrypt.Net.BCrypt.Verify(Admin.Password, matchedAdmin.Password);

                if (passwordOk)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, matchedAdmin.Name),
                        new Claim(ClaimTypes.NameIdentifier, matchedAdmin.Id.ToString()),
                        new Claim("Username", matchedAdmin.Username)
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

                    return RedirectToPage("../Index");
                }
                else
                {
                    TempData["Message"] = "Usuário e/ou senha inválidos";
                }
            }

            AdminExist = await _context.Admins.AnyAsync();

            return Page();
        }
    }
}
