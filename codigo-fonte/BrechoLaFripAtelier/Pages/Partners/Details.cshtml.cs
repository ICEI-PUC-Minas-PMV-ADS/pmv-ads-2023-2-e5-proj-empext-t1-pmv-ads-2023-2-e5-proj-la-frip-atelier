using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Partners
{
    public class DetailsModel : PageModel
    {
        private readonly MyDbContext _context;

        public DetailsModel(MyDbContext context)
        {
            _context = context;
        }

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
    }
}
