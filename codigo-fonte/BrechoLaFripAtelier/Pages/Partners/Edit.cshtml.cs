using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Partners
{
    public class EditModel : PageModel
    {
        private readonly MyDbContext _context;

        public EditModel(MyDbContext context)
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
            Partner = partner;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Partner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartnerExists(Partner.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PartnerExists(int id)
        {
            return (_context.Partners?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
