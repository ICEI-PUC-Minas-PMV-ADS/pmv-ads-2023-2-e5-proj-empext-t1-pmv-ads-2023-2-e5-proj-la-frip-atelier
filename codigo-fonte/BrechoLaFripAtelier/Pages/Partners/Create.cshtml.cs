using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BrechoLaFripAtelier.Models;

namespace BrechoLaFripAtelier.Pages.Partners
{
    public class CreateModel : PageModel
    {
        private readonly BrechoLaFripAtelier.Models.MyDbContext _context;

        public CreateModel(BrechoLaFripAtelier.Models.MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Partner Partner { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Partners == null || Partner == null)
            {
                return Page();
            }

            _context.Partners.Add(Partner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
