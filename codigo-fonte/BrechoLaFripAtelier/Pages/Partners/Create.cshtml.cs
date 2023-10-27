using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrechoLaFripAtelier.Pages.Partners
{
    public class CreateModel : PageModel
    {
        private readonly MyDbContext _context;

        public CreateModel(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Partner Partner { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Partners == null || Partner == null)
            {
                return Page();
            }

            _context.Partners.Add(Partner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
