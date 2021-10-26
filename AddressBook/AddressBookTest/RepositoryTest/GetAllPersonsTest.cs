using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdressBookTest.RepositoryTest
{
    [TestClass]
    public class GetAllPersonsTest : RepositoryTest
    {
        [TestMethod]
        public void GetAllPersons()
        {
            var sut = new EfGenericRepository<Person>(PersonDataContext);
            var result = sut.GetAll();

            Assert.AreEqual(10, result.Count);
        }

        [TestMethod]
        public void GetNotAllPersons()
        {
            var sut = new EfGenericRepository<Person>(PersonDataContext);
            var result = sut.GetAll();

            Assert.AreNotEqual(9, result.Count);
        }
    }
}