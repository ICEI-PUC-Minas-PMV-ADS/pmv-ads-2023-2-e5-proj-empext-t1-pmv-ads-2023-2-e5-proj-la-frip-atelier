using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Partners
{
    public class DeleteModel : PageModel
    {
        private readonly MyDbContext _context;

        public DeleteModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Partner Partner { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Partners == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FirstOrDefaultAsync(m => m.Id == id);

            if (partner == null)
            {
                return NotFound();
            }
            else
            {
                Partner = partner;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Partners == null)
            {
                return NotFound();
            }
            var partner = await _context.Partners.FindAsync(id);

            if (partner != null)
            {
                Partner = partner;
                _context.Partners.Remove(Partner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
