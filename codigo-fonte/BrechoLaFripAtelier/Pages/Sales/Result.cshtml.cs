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

        public async Task OnGetAsync(int? partnerId,string? date)
        {
            IQueryable<Sale> sales = _context.Sales;

            if (partnerId != null)
            {
                sales = sales.Where(s => s.Product.Partner.Id == partnerId);
            }

            if (date != null)
            {
                var parsedDate = DateTime.Parse(date);
                sales = sales.Where(s => s.DateOfSale.Equals(parsedDate));
            }

            Sale = await sales.Include(s => s.Product)
                              .ThenInclude(p => p.Partner)
                              .ToListAsync();
        }
    }
}