using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Sales
{
    public class ResultModel : PageModel
    {
        private readonly MyDbContext _context;

        public ResultModel(MyDbContext context)
        {
            _context = context;
        }

        public IList<Sale> Sale { get; set; } = default!;

        public async Task OnGetAsync(int? id)
        {
            IQueryable<Sale> sales = _context.Sales;

            if (id != null)
            {
                sales = sales.Where(s => s.Product.Partner.Id == id);
            }


            Sale = await sales.Include(s => s.Product)
                              .ThenInclude(p => p.Partner)
                              .ToListAsync();
        }
    }
}
