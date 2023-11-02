using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrechoLaFripAtelier.Models;

namespace BrechoLaFripAtelier.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly BrechoLaFripAtelier.Models.MyDbContext _context;

        public IndexModel(BrechoLaFripAtelier.Models.MyDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

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
                Product = await products.ToListAsync();

            }

            if (_context.Products != null)
            {
                Product = await _context.Products
                .Include(p => p.Partner).ToListAsync();
            }
        }
    }
}
