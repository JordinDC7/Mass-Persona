using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mass_Persona.Data;
using Mass_Persona.Models;

namespace Mass_Persona.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Mass_Persona.Data.ReviewContext _context;

        public CreateModel(Mass_Persona.Data.ReviewContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Review.DateReviewed = Review.DateReviewed.ToUniversalTime();

            _context.reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Reviews");
        }
    }
}
