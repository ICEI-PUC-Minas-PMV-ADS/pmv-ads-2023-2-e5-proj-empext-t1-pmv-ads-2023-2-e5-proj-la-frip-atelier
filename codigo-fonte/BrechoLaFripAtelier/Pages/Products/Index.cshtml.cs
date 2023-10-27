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

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products
                .Include(p => p.Partner).ToListAsync();
            }
        }
    }
}
