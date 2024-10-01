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
    public class ReviewsModel : PageModel
    {
        private readonly Mass_Persona.Data.ReviewContext _context;

        public ReviewsModel(Mass_Persona.Data.ReviewContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Review = await _context.reviews.ToListAsync();
        }
    }
}
