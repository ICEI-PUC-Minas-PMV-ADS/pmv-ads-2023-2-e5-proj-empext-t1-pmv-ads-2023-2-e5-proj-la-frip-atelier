﻿using BrechoLaFripAtelier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Pages.Sales
{
    public class DeleteModel : PageModel
    {
        private readonly MyDbContext _context;

        public DeleteModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sale Sale { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sales == null)
            {
                return NotFound();
            }

            var sale = await _context.Sales.FirstOrDefaultAsync(m => m.Id == id);

            if (sale == null)
            {
                return NotFound();
            }
            else
            {
                Sale = sale;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Sales == null)
            {
                return NotFound();
            }
            var sale = await _context.Sales.FindAsync(id);

            if (sale != null)
            {
                Sale = sale;
                _context.Sales.Remove(Sale);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
