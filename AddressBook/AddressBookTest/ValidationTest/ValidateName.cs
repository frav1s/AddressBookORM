using AddressBookLibrary.Model;
using AddressBookLibrary.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdressBookTest.ValidationTest
{
    [TestClass]
    public class ValidateName : Validation
    {
        private readonly Person p = new Person();
        private ValidationModel validate = new ValidationModel();

        [TestMethod]
        public void should_return_to_write_name_of_account()
        {
            p.FirstName = "";
            p.LastName = "";
            validate = ValidateName(p);
            Assert.AreEqual(validate.Message, "Введите имя для этого контакта.");
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void should_return_to_write_FirstName_of_account()
        {
            p.FirstName = "";
            p.LastName = "QQ";
            validate = ValidateName(p);
            Assert.AreEqual(validate.Message, "Имя обязательно.");
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void should_return_to_write_LastName_of_account()
        {
            p.FirstName = "QQ";
            p.LastName = "";
            validate = ValidateName(p);
            Assert.AreEqual(validate.Message, "Фамилия обязательна.");
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void good_lastname_and_firstname()
        {
            p.FirstName = "QQ";
            p.LastName = "RR";
            validate = ValidateName(p);
            Assert.AreEqual(validate.Message, "");
            Assert.AreEqual(true, validate.Result);
        }
    }
}