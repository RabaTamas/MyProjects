using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data;

namespace Otthonbazar.Pages.Advertisements
{
    public class DeleteModel : PageModel
    {
        private readonly Otthonbazar.Data.ApplicationDbContext _context;

        public DeleteModel(Otthonbazar.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Advertisement Advertisement { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Advertisements == null)
            {
                return NotFound();
            }

            var advertisement = await _context.Advertisements.FirstOrDefaultAsync(m => m.Id == id);

            if (advertisement == null)
            {
                return NotFound();
            }
            else 
            {
                Advertisement = advertisement;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Advertisements == null)
            {
                return NotFound();
            }
            var advertisement = await _context.Advertisements.FindAsync(id);

            if (advertisement != null)
            {
                Advertisement = advertisement;
                _context.Advertisements.Remove(Advertisement);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
