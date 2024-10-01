namespace Mass_Persona.Data;

using Mass_Persona.Models;
using Microsoft.EntityFrameworkCore;




public class ReviewContext : DbContext
{
    public ReviewContext(DbContextOptions<ReviewContext> options) : base(options) { }

    public DbSet<Review> reviews { get; set; }
}

