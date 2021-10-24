using AddressBookLibrary.Model;
using AddressBookLibrary.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookTest.ValidationTest
{
    [TestClass]
    public class ValidateData : Validation
    {
        private readonly Person p = new Person();
        private ValidationModel validate = new ValidationModel();

        [TestMethod]
        public void should_return_example_of_date()
        {
            p.BirthDate = "";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.DATE_NOT_FOUND]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void should_return_false_month()
        {
            p.BirthDate = "10.25.2001";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.MONTH_INVALID]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void should_return_false_day()
        {
            p.BirthDate = "55.12.2001";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.DAY_INVALID]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void should_return_false_year()
        {
            p.BirthDate = "12.12.1800";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.YEAR_IS_INVALID]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void fasle_leap_year()
        {
            p.BirthDate = "29.02.2015";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.YEAR_IS_LEAPYEAR]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void true_leap_year()
        {
            p.BirthDate = "30.02.2016";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.YEAR_IS_NOT_LEAPYEAR]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void false_IsThrityDay()
        {
            p.BirthDate = "31.09.2016";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, validate.errors[ErrorName.TOO_MUCH_DAYS]);
            Assert.AreEqual(false, validate.Result);
        }

        [TestMethod]
        public void Good_date()
        {
            p.BirthDate = "25.08.2001";
            validate = ValidateDate(p);
            Assert.AreEqual(validate.Message, "");
            Assert.AreEqual(true, validate.Result);
        }
    }
}