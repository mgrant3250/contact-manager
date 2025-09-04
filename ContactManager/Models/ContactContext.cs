using Microsoft.EntityFrameworkCore;
using System.Runtime.ExceptionServices;
namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        
        public ContactContext(DbContextOptions<ContactContext> options) 
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        // seeds initial data into databases
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family"},
                new Category { CategoryId = 2, Name = "Friend"},
                new Category { CategoryId = 3, Name = "co-worker"}
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "First",
                    LastName = "Last",
                    Phone = "555-5555",
                    Email = "Email@email.com",
                    CategoryId = 2
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "324-8432",
                    Email = "Email@gmail.com",
                    CategoryId = 1
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Phone = "543-3251",
                    Email = "Email@Yahoo.com",
                    CategoryId = 2
                }
                );
        }
    }
}
