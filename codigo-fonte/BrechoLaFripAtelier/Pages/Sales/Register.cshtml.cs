using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Sales
{
    public class RegisterModel : PageModel
    {
        private readonly MyDbContext _context;

        public RegisterModel(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? productId)
        {
            if (productId == null)
            {
                return NotFound();
            }

            bool saleExist = await _context.Sales.AnyAsync(s => s.ProductId == productId);

            if (saleExist)
            {
                int saleId = await _context.Sales
                                    .Where(s => s.ProductId == productId)
                                    .Select(s => s.Id)
                                    .FirstOrDefaultAsync();

                return RedirectToPage("../Sales/Edit", new { id = saleId });
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

            return RedirectToPage("./SalesPerDay");
        }
    }
}
