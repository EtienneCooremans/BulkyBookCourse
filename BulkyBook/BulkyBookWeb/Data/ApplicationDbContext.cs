using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext // import entity framework
    {
        // configuration for entity framework
        // pass connection string
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } // create table 'categories'

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            // default function that we will override to suit our own needs.
            // using the modelbuilder we can seed data
            modelbuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Horror", DisplayOrder = 4 }
                );
        }
    }
}
