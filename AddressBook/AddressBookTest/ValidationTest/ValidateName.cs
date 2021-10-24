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
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.NAME_NOT_FOUND]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void should_return_to_write_FirstName_of_account()
        {
            p.FirstName = "";
            p.LastName = "QQ";
            validate = ValidateName(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.NAME_IS_MALFORMED]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void should_return_to_write_LastName_of_account()
        {
            p.FirstName = "QQ";
            p.LastName = "";
            validate = ValidateName(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.LASTNAME_IS_MALFORMED]);
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