using AddressBookLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace AddressBookLibrary.DatabaseContext
{
    public class AddressBookDbContext : DbContext
    {
        public AddressBookDbContext()
        {
        }

        public AddressBookDbContext(DbContextOptions<AddressBookDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-8B3NTNB\\SQLEXPRESS;Database=AddressBook12; Integrated Security=true");
        }
    }
}