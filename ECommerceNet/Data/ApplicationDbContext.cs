using ECommerceNet.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceNet.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Comedy", DisplayOrder = 4 },  // New category
                new Category { Id = 5, Name = "Drama", DisplayOrder = 5 },    // New category
                new Category { Id = 6, Name = "Horror", DisplayOrder = 6 },    // New category
                new Category { Id = 7, Name = "Romance", DisplayOrder = 7 },   // New category
                new Category { Id = 8, Name = "Adventure", DisplayOrder = 8 }, // New category
                new Category { Id = 9, Name = "Documentary", DisplayOrder = 9 }, // New category
                new Category { Id = 10, Name = "Fantasy", DisplayOrder = 10 }


                );
        }
    }
}
