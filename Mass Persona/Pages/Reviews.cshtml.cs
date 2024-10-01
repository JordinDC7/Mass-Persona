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
        private readonly ReviewContext _context;

        public ReviewsModel(ReviewContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get; set; } = new List<Review>();

        // Filtering properties
        [BindProperty(SupportsGet = true)]
        public string SearchCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? SearchRating { get; set; }

        // Sorting properties
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        // Pagination properties
        public int TotalReviews { get; set; }
        public int PageSize { get; set; } = 5;
        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;

        public async Task OnGetAsync()
        {
            // query
            var reviewsQuery = _context.reviews.AsQueryable();

            // filter by category
            if (!string.IsNullOrEmpty(SearchCategory))
            {
                reviewsQuery = reviewsQuery.Where(r => r.Category == SearchCategory);
            }

            // filter by rating 
            if (SearchRating.HasValue)
            {
                reviewsQuery = reviewsQuery.Where(r => r.Rating == SearchRating.Value);
            }

            // sort logic
            switch (SortOrder)
            {
                case "category_asc":
                    reviewsQuery = reviewsQuery.OrderBy(r => r.Category);
                    break;
                case "category_desc":
                    reviewsQuery = reviewsQuery.OrderByDescending(r => r.Category);
                    break;
                case "rating_asc":
                    reviewsQuery = reviewsQuery.OrderBy(r => r.Rating);
                    break;
                case "rating_desc":
                    reviewsQuery = reviewsQuery.OrderByDescending(r => r.Rating);
                    break;
                default:
                    reviewsQuery = reviewsQuery.OrderBy(r => r.DateReviewed);  // default sorting by the date
                    break;
            }

            // initial count
            TotalReviews = await reviewsQuery.CountAsync();

            // pagination logic
            Review = await reviewsQuery
                .Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}
