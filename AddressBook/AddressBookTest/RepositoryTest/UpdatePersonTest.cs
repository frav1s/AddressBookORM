using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AddressBookTest.RepositoryTest
{
    [TestClass]
    public class UpdatePersonTest : RepositoryTest
    {
        [TestMethod]
        public void It_should_update_a_product_successfully_into_data_store()
        {
            //Arrange
            var expected = "Rat";
            var sut = new EfGenericRepository<Person>(PersonDataContext);
            var person = new Person { FirstName = "Egor", LastName = "Kovac" };
            //Act
            var result = sut.Add(person);
            result.FirstName = expected;
            sut.Update(result);
            result = PersonDataContext.Persons.First(p => p.Id == result.Id);
            //Assert
            Assert.AreEqual(expected, result.FirstName);
        }
    }
}