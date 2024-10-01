using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mass_Persona.Data;
using Mass_Persona.Models;

namespace Mass_Persona.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Mass_Persona.Data.ReviewContext _context;

        public DeleteModel(Mass_Persona.Data.ReviewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Review Review { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.reviews.FirstOrDefaultAsync(m => m.ReviewID == id);

            if (review == null)
            {
                return NotFound();
            }
            else
            {
                Review = review;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.reviews.FindAsync(id);
            if (review != null)
            {
                Review = review;
                _context.reviews.Remove(Review);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Reviews");
        }
    }
}
