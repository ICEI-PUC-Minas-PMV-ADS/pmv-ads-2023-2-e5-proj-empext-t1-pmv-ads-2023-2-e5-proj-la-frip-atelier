using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrechoLaFripAtelier.Pages.Sales
{
    public class RegisterModel : PageModel
    {
        private readonly MyDbContext _context;

        public RegisterModel(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? productId)
        {

            if (productId == null)
            {
                return NotFound();
            }

            ViewData["ProductId"] = productId;

            return Page();
        }

        [BindProperty]
        public Sale Sale { get; set; } = default!;


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Sales == null || Sale == null)
            {
                return Page();
            }

            _context.Sales.Add(Sale);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
