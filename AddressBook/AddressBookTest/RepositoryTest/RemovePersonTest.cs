using System.Linq;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdressBookTest.RepositoryTest
{
    [TestClass]
    public class RemovePersonTest : RepositoryTest
    {
        [TestMethod]
        public void It_should_remove_a_product_successfully_from_the_data_store()
        {
            //Arrange
            var sut = new EfGenericRepository<Person>(PersonDataContext);
            var person = new Person { FirstName = "Vladislav", LastName = "Kovac" };

            //Act
            var result = sut.Add(person);
            sut.Remove(result);
            var isExists = PersonDataContext.Persons.Any(p => p.Id == result.Id);
            //Assert
            Assert.IsFalse(isExists);
        }
    }
}