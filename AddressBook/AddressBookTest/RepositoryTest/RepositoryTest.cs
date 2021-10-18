using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookTest.RepositoryTest
{
    [TestClass]
    public class RepositoryTest : IDisposable
    {
        protected readonly AddressBookDbContext PersonDataContext;

        public RepositoryTest()
        {
            var options = new DbContextOptionsBuilder<AddressBookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            PersonDataContext = new AddressBookDbContext(options);
            PersonDataContext.Database.EnsureCreated();

            Seed(PersonDataContext);
        }

        public void Dispose()
        {
            PersonDataContext.Database.EnsureDeleted();
            PersonDataContext.Dispose();
        }

        private void Seed(AddressBookDbContext personrDataContext)
        {
            var persons = new[]
            {
                new Person { Id = 1, FirstName = "Cucumber" },
                new Person { Id = 2, FirstName = "Ilia" },
                new Person { Id = 3, FirstName = "Fravis" },
                new Person { Id = 4, FirstName = "sk0be" },
                new Person { Id = 5, FirstName = "worst1nme" },
                new Person { Id = 6, FirstName = "white nigga" },
                new Person { Id = 7, FirstName = "black nigga" },
                new Person { Id = 8, FirstName = "Racist" },
                new Person { Id = 9, FirstName = "Jake" },
                new Person { Id = 10, FirstName = "Retard" }
            };

            personrDataContext.Persons.AddRange(persons);
            personrDataContext.SaveChanges();
        }
    }
}