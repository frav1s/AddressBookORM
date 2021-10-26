using AddressBookLibrary.Model;
using AddressBookLibrary.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdressBookTest.ValidationTest
{
    [TestClass]
    public class ValidationFormTest : Validation
    {
        private readonly Person p = new Person();
        private ValidationModel validation = new ValidationModel();

        [TestMethod]
        public void Validation_form_true()
        {
            p.FirstName = "QQ";
            p.LastName = "RR";
            p.BirthDate = "25.08.2001";
            p.CellPhone = "(123) 123-1231";
            p.OfficePhone = "(123) 123-1232";
            p.HomePhone = "(123) 123-1233";
            validation = ValidateForm(p);
            Assert.AreEqual(validation.Message, "");
            Assert.AreEqual(true, validation.Result);
        }

        [TestMethod]
        public void Validation_form_false()
        {
            p.FirstName = "";
            p.LastName = "RR";
            p.BirthDate = "25.08.2001";
            p.CellPhone = "(123) 123-1231";
            p.OfficePhone = "(123) 123-1232";
            p.HomePhone = "(123) 123-1233";
            validation = ValidateForm(p);
            Assert.AreEqual(validation.Message, "");
            Assert.AreEqual(false, validation.Result);
        }
    }
}