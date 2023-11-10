using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BrechoLaFripAtelier.Pages.Sales
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Sale Sale { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
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
