using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrechoLaFripAtelier.Pages.Admins
{
    public class RegisterModel : PageModel
    {
        private readonly MyDbContext _context;

        public RegisterModel(MyDbContext context)
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
            if (!ModelState.IsValid || _context.Admins == null || Admin == null)
            {
                return Page();
            }

            Admin.Password = BCrypt.Net.BCrypt.HashPassword(Admin.Password);
            _context.Admins.Add(Admin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Login");
        }
    }
}
