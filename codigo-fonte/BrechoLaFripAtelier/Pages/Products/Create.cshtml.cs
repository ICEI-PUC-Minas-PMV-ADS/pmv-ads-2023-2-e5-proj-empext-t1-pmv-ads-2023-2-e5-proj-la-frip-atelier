using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BrechoLaFripAtelier.Pages.Products
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
            ViewData["PartnerId"] = new SelectList(_context.Partners, "Id", "CPFnumber");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Products == null || Product == null)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            if (Product.Status == ProductStatus.Vendido)
            {
                return RedirectToPage("../Sales/Register", new { productId = Product.Id });
            }

            return RedirectToPage("./Index");
        }
    }
}
