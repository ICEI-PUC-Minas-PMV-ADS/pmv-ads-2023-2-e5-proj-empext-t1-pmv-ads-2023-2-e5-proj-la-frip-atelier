using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrechoLaFripAtelier.Models;

namespace BrechoLaFripAtelier.Pages.Partners
{
    public class DetailsModel : PageModel
    {
        private readonly BrechoLaFripAtelier.Models.MyDbContext _context;

        public DetailsModel(BrechoLaFripAtelier.Models.MyDbContext context)
        {
            _context = context;
        }

      public Partner Partner { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Partners == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FirstOrDefaultAsync(m => m.Id == id);
            if (partner == null)
            {
                return NotFound();
            }
            else 
            {
                Partner = partner;
            }
            return Page();
        }
    }
}
