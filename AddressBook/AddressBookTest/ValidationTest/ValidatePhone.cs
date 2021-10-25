using AddressBookLibrary.Model;
using AddressBookLibrary.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressBookTest.ValidationTest
{
    [TestClass]
    public class ValidatePhone : Validation
    {
        private readonly Person p = new Person();
        private ValidationModel validate = new ValidationModel();

        [TestMethod]
        public void false_ceil_phone()
        {
            p.CellPhone = "(123) 123-123";
            validate = ValidatePhone(p);
            Assert.AreEqual(validate.Message, "Введенный номер  телефона не содержит достаточного количества цифр.");
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void false_home_phone()
        {
            p.CellPhone = "";
            p.OfficePhone = "";
            p.HomePhone = "(123) 123-123";
            validate = ValidatePhone(p);
            Assert.AreEqual(validate.Message, "Введенный номер  телефона не содержит достаточного количества цифр.");
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void false_office_phone()
        {
            var v2alidate = new ValidationModel();
            p.HomePhone = "";
            p.CellPhone = "";
            p.OfficePhone = "(123) 123-123";
            v2alidate = ValidatePhone(p);
            Assert.AreEqual(v2alidate.Message, "Введенный номер  телефона не содержит достаточного количества цифр.");
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void Good_phones()
        {
            p.CellPhone = "(123) 123-1231";
            p.OfficePhone = "(123) 123-1232";
            p.HomePhone = "(123) 123-1233";
            validate = ValidatePhone(p);
            Assert.AreEqual(validate.Message, "");
            Assert.AreEqual(true, validate.Result);
        }
    }
}