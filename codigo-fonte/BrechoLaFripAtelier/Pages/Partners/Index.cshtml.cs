using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Partners
{
    public class IndexModel : PageModel
    {
        private readonly MyDbContext _context;

        public IndexModel(MyDbContext context)
        {
            _context = context;
        }

        public IList<Partner> Partner { get; set; } = default!;

        public async Task OnGetAsync(string search)
        {
            // Obtenha todos os parceiros da base de dados
            IQueryable<Partner> partners = _context.Partners;

            // Se houver uma pesquisa, aplique o filtro
            if (!string.IsNullOrEmpty(search))
            {
                partners = partners.Where(p => p.Name.Contains(search));
            }

            // Carregue os resultados filtrados na propriedade Partner
            if (_context.Partners != null)
            {
                Partner = await partners.ToListAsync();
            }
        }
    }
}
