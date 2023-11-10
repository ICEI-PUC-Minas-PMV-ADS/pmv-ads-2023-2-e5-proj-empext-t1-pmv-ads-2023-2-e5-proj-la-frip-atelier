using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MyDbContext _context;

        public IndexModel(MyDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;

        public async Task OnGetAsync(string search)
        {
            // Obtenha todos os produtos da base de dados
            IQueryable<Product> products = _context.Products;

            // Se houver uma pesquisa, aplique o filtro
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.Contains(search));
            }

            // Carregue os resultados filtrados na propriedade Products
            if (_context.Products != null)
            {
                Product = await products
                .Include(p => p.Partner)
                .ToListAsync();
            }
        }
    }
}
