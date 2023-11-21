using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BrechoLaFripAtelier.Pages.Admins
{
    public class RecoveryModel : PageModel
    {
        private readonly MyDbContext _context;

        public RecoveryModel(MyDbContext context)
        {
            _context = context;
        }

        [Display(Name = "Pergunta de Segurança")]
        public string SecurityQuestion { get; set; }

        [Display(Name = "Resposta de Segurança")]
        [Required(ErrorMessage = "Informe a resposta para a pergunta")]
        [BindProperty]
        public string SecurityResponse { get; set; }


        public async Task OnGetAsync()
        {
            var admin = await _context.Admins.FirstOrDefaultAsync();

            SecurityQuestion = admin?.SecurityQuestion;
        }


        public async Task<IActionResult> OnPostAsync()
        {
            bool adminValid = await _context.Admins.AnyAsync(a => a.SecurityResponse == SecurityResponse);

            if (!adminValid)
            {
                var admin = await _context.Admins.FirstOrDefaultAsync();

                SecurityQuestion = admin?.SecurityQuestion;

                TempData["ErrorMessage"] = "Resposta de segurança incorreta.";

                return Page();
            }

            string vToken = Guid.NewGuid().ToString();

            HttpContext.Session.SetString("VerificationToken", vToken);

            return RedirectToPage("ResetPassword", new { vToken });
        }
    }
}
