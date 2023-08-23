using eBook.Model.Models;
using eBooksWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace eBook.DataAccess
{
    public class ApplicationContextDB : DbContext
    {
        public ApplicationContextDB(DbContextOptions<ApplicationContextDB> options) : base(options)
        {
             
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id=2, Name= "Scifi", DisplayOrder=2},
                new Category { Id = 3, Name="Horror", DisplayOrder=3});

            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    Id= 1, 
                    Title = "Fortune of Time",
                    Description = "Present of book bbook description",
                    ISBN = "SW000999",
                    Author = "Kapil",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80
                },
                  new Product
                  {
                      Id = 2,
                      Title = "Rich dad poor dad",
                      Description = "Present of book bbook description",
                      ISBN = "SW000999",
                      Author = "kapil",
                      ListPrice = 99,
                      Price = 90,
                      Price50 = 85,
                      Price100 = 80
                  }
                  ,
                  new Product
                  {
                      Id = 3,
                      Title = "C# Book",
                      Description = "Present of book bbook description",
                      ISBN = "SW000999",
                      Author = "kapil",
                      ListPrice = 99,
                      Price = 90,
                      Price50 = 85,
                      Price100 = 80
                  }
                  );

        }

        
    }
}
