using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Sales
{
    public class SalesPerPartnerModel : PageModel
    {

        private readonly MyDbContext _context;

        public SalesPerPartnerModel(MyDbContext context)
        {
            _context = context;
        }

        public class PartnerSalesSummary
        {
            public Partner? Partner { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
            public decimal TotalCommission => TotalPrice * (Partner?.Commission ?? 0) / 100;
        }

        public List<PartnerSalesSummary> PartnerSalesSummaries { get; set; } = new List<PartnerSalesSummary>();

        public void OnGet()
        {

            var soldProducts = _context.Sales
                .Include(s => s.Product)
                .ThenInclude(p => p.Partner);

            PartnerSalesSummaries = soldProducts
                .GroupBy(s => s.Product.Partner)
                .Select(g => new PartnerSalesSummary
                {
                    Partner = g.Key,
                    Quantity = g.Count(),
                    TotalPrice = g.Sum(s => s.Product.Price)
                })
                .OrderByDescending(s => s.Quantity)
                .ToList();
        }
    }
}