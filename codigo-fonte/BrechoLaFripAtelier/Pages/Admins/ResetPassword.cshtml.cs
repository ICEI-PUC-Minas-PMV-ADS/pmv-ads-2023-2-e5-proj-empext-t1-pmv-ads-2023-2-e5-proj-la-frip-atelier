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

        public string ConfirmPassword { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            int adminId = 1;

            var admin = await _context.Admins.FindAsync(adminId);

            if (admin == null)
            {
                return NotFound();
            }

            if (NewPassword != ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "As senhas n�o coincidem.");
            }

            // Atualize a senha do administrador
            admin.Password = BCrypt.Net.BCrypt.HashPassword(NewPassword);

            _context.Entry(admin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                // Armazene a mensagem de sucesso para mostrar na pr�xima requisi��o
                TempData["SuccessMessage"] = "Senha alterada com sucesso!";
            }
            catch (DbUpdateConcurrencyException)
            {
                // Trate exce��es de concorr�ncia, se necess�rio
                throw;
            }

            // Continua na pagina ResetPassword.cs.html
            return Page();
        }
    }
}