using System.Linq;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdressBookTest.RepositoryTest
{
    [TestClass]
    public class AddPersonTest : RepositoryTest
    {
        [TestMethod]
        public void It_should_add_a_person_successfully_into_data_store()
        {
            //Arrange

            var sut = new EfGenericRepository<Person>(PersonDataContext);
            var product = new Person { FirstName = "Vladislav", LastName = "Kovac" };
            //Act
            sut.Add(product);
            var result = sut.GetAll();

            //Assert
            Assert.AreEqual("Vladislav", result.Last().FirstName);
            Assert.AreEqual("Kovac", result.Last().LastName);

        }
        [TestMethod]
        public void It_should_not_add_a_person_successfully_into_data_store()
        {
            //Arrange

            var sut = new EfGenericRepository<Person>(PersonDataContext);
            var product = new Person { };
            //Act
            sut.Add(product);
            var result = sut.GetAll();

            //Assert
            Assert.AreEqual(null, result.Last().FirstName);
            Assert.AreEqual(null, result.Last().LastName);

        }
    }
}