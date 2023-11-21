using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Admins
{
    public class ResetPasswordModel : PageModel
    {
        private readonly MyDbContext _context;

        public ResetPasswordModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string NewPassword { get; set; }

        [BindProperty]
        public string ConfirmPassword { get; set; }


        public IActionResult OnGet(string vToken)
        {
            if (string.IsNullOrEmpty(vToken) || !vToken.Equals(HttpContext.Session.GetString("VerificationToken")))
            {
                return RedirectToPage("AccessDenied");
            }

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            var admin = await _context.Admins.FirstOrDefaultAsync();

            if (admin == null)
            {
                return NotFound();
            }

            if (NewPassword != ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "As senhas não coincidem.");
            }

            admin.Password = BCrypt.Net.BCrypt.HashPassword(NewPassword);

            _context.Entry(admin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Senha alterada com sucesso!";
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Page();
        }
    }
}