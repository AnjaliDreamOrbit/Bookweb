using BookwebProject.Models;
using Microsoft.EntityFrameworkCore; 

namespace BookwebProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        //pass the connectionString 
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) :base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }//create table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "Comedy", DisplayOrder = 2},
                  new Category { Id = 3, Name = "History", DisplayOrder = 3},
                   new Category { Id = 4, Name = "Scifi", DisplayOrder = 4}

                );
             
        }

    }
}
