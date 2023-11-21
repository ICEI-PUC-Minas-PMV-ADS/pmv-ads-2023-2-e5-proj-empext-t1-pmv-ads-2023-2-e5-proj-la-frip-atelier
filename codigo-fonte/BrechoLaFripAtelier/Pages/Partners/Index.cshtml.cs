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

            IQueryable<Partner> partners = _context.Partners;

            if (!string.IsNullOrEmpty(search))
            {
                partners = partners.Where(p => p.Name.Contains(search));
            }

            if (_context.Partners != null)
            {
                Partner = await partners
                    .OrderBy(p => p.Name)
                    .ToListAsync();
            }
        }
    }
}
