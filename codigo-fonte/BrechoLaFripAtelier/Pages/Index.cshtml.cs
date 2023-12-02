using BrechoLaFripAtelier.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace BrechoLaFripAtelier.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyDbContext _dbContext;

        public IndexModel(ILogger<IndexModel> logger, MyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            ViewData["TotalItemsCadastrados"] = _dbContext.Products.Count();

            DateTime hoje = DateTime.Today;
            ViewData["TotalItemsVendidosNoDia"] = _dbContext.Sales
                .Count(s => s.DateOfSale == hoje);

            ViewData["ParceirasAguardandoPagamento"] = _dbContext.Sales
                .Count(s => s.Status == Models.CommissionStatus.Pendente);
        }
    }
}
