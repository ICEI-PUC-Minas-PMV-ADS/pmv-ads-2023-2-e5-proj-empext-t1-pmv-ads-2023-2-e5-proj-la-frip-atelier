using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Sales
{
    public class IndexModel : PageModel
    {
        private readonly MyDbContext _context;

        public IndexModel(MyDbContext context)
        {
            _context = context;
        }

        public IList<Sale> Sale { get; set; } = default!;

        public async Task OnGetAsync(string search)
        {
            IQueryable<Sale> sales = _context.Sales;

            if (!string.IsNullOrEmpty(search))
            {
                //sales = sales.Where(p => p.Name.Contains(search));
            }

            if (_context.Sales != null)
            {
                Sale = await sales.ToListAsync();

            }

            if (_context.Sales != null)
            {
                Sale = await _context.Sales
                .Include(s => s.Product)
                .ThenInclude(p => p.Partner)
                .ToListAsync();
                
            }
        }
    }
}
