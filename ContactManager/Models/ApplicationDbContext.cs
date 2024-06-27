using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                Id = Guid.NewGuid(),
                FirstName = "Ravindra",
                LastName = "Pasuvula",
                Email = "ravinaga9959@gmail.com",
                PhoneNumber = "9160422130",
                CountryName = "India",
                Address = "Gachibowli, Hyderabad"
            });
        }
    }
}

