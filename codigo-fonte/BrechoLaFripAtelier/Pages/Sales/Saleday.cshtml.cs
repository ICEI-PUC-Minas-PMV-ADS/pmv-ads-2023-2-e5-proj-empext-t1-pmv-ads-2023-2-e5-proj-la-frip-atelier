using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrechoLaFripAtelier.Pages.Sales
{
    public class SaledayModel : PageModel
    {
        private readonly MyDbContext _context;

        public SaledayModel(MyDbContext context)
        {
            _context = context;
        }

        public List<SalesByDayViewModel> SalesByDay { get; set; } = new List<SalesByDayViewModel>();

        public async Task OnGetAsync(DateTime? startDate, DateTime? endDate)
        {
            var query = _context.Sales
                .Include(s => s.Product)
                .AsQueryable();  // Inicializa a consulta

            if (startDate.HasValue)
            {
                query = query.Where(s => s.DateOfSale.Date >= startDate.Value.Date);
            }

            if (endDate.HasValue)
            {
                query = query.Where(s => s.DateOfSale.Date <= endDate.Value.Date);
            }

            var salesByDay = await query
                .GroupBy(s => s.DateOfSale.Date)
                .Select(group => new SalesByDayViewModel
                {
                    Date = group.Key,
                    TotalItemsSold = group.Count(),
                    TotalAmount = group.Sum(s => s.Product.Price)
                })
                .OrderByDescending(s => s.Date)
                .ToListAsync();

            SalesByDay = salesByDay;
        }
    }

    public class SalesByDayViewModel
    {
        public DateTime Date { get; set; }
        public int TotalItemsSold { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
