using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Admins
{
    public class RecoveryModel : PageModel
    {
        private readonly MyDbContext _context;

        public RecoveryModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string SecurityResponse { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SecurityQuestion { get; set; }

        public async Task OnGetAsync()
        {
            // Recupera a pergunta secreta do administrador com Id igual a 1
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Id == 1);

            // Define a pergunta secreta na propriedade do modelo
            SecurityQuestion = admin?.SecurityQuestion;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Verifica se a resposta � pergunta secreta est� correta
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Username == Username && a.SecurityResponse == SecurityResponse);

            if (admin == null)
            {
                // Se a resposta estiver incorreta, mantenha a pergunta secreta vis�vel
                var existingAdmin = await _context.Admins.FirstOrDefaultAsync(a => a.Id == 1);
                SecurityQuestion = existingAdmin?.SecurityQuestion;

                TempData["ErrorMessage"] = "Nome de usu�rio ou resposta de seguran�a incorretos. Tente novamente.";
                return Page();
            }

            return RedirectToPage("ResetPassword");
        }
    }
}
