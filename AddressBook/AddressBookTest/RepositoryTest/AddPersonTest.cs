using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AddressBookTest.RepositoryTest
{
    [TestClass]
    public class AddPersonTest : RepositoryTest
    {
        [TestMethod]
        public void It_should_add_a_person_successfully_into_data_store()
        {
            //Arrange

            var userRepo = new EfGenericRepository<Person>(PersonDataContext);
            var personMock = new Person { FirstName = "Vladislav", LastName = "Kovac" };
            //Act
            Person user = userRepo.Add(personMock);
            // var result = userRepo.GetAll();

            //Assert
            Assert.AreEqual(personMock, user);
        }
    }
}