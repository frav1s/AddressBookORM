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

            // var query = new PersonQuery(personDataContext);
            var result = sut.GetAll();

            Assert.AreEqual(10, result.Count);
        }
    }
}