using AddressBookLibrary.Model;
using System;
using System.Linq;
using System.Collections.Generic;

namespace AddressBookLibrary.Validation
{
    public class Validation : ValidationLogic
    {
        public static ValidationModel ValidateForm(Person p)
        {
            var fullValidation = new ValidationModel();
            ValidationModel nameValidation;
            ValidationModel dateValidation;
            ValidationModel phoneValidation;

            fullValidation.Message = "";
            fullValidation.Result = true;

            nameValidation = ValidateName(p);
            dateValidation = ValidateDate(p);
            phoneValidation = ValidatePhone(p);

            if (!nameValidation.Result)
            {
                fullValidation.Message = nameValidation.Message;
                fullValidation.Result = nameValidation.Result;
                return fullValidation;
            }

            if (!dateValidation.Result)
            {
                fullValidation.Message = dateValidation.Message;
                fullValidation.Result = dateValidation.Result;
                return fullValidation;
            }

            if (!phoneValidation.Result)
            {
                fullValidation.Message = phoneValidation.Message;
                fullValidation.Result = phoneValidation.Result;
                return fullValidation;
            }

            return fullValidation;
        }

        /// <summary>
        ///     Проверяет имя и фамилию
        /// </summary>
        /// <returns>
        ///     Returns ValidationModel result and message
        /// </returns>
        public static ValidationModel ValidateName(Person p)
        {
            var nameCheck = new ValidationModel()
            {
                Message = "",
                Result = true
            };

            if (p.FirstName.Length == 0 && p.LastName.Length == 0)
            {
                nameCheck.Message = nameCheck.errors[ErrorName.NAME_NOT_FOUND]._message;
                nameCheck.Result = false;
                return nameCheck;
            }

            if (p.FirstName.Length == 0)
            {
                nameCheck.Message = nameCheck.errors[ErrorName.NAME_IS_MALFORMED]._message;
                nameCheck.Result = false;
                return nameCheck;
            }

            if (p.LastName.Length == 0)
            {
                nameCheck.Message = nameCheck.errors[ErrorName.LASTNAME_IS_MALFORMED]._message;
                nameCheck.Result = false;
                return nameCheck;
            }

            return nameCheck;
        }

        /// <summary>
        ///     Проверяет дату рождения
        /// </summary>
        /// <returns>
        ///     Returns ValidationModel result and message
        /// </returns>
        public static ValidationModel ValidateDate(Person p)
        {
            var dateCheck = new ValidationModel
            {
                Message = "",
                Result = true
            };

            if (p.BirthDate == "  /  /")
            {
                dateCheck.Result = true;
                return dateCheck;
            }

            var digits = CleanNumbers(p.BirthDate);

            if (!CheckNumLen(digits, 8))
            {
                dateCheck.Message = dateCheck.errors[ErrorName.DATE_NOT_FOUND]._message;
                dateCheck.Result = false;
                return dateCheck;
            }

            if (p.BirthDate.Length != 0)
            {
                int.TryParse(digits.Substring(2, 2), out var month);

                int.TryParse(digits.Substring(0, 2), out var day);

                int.TryParse(digits.Substring(4, 4), out var year);

                if (!(month >= 1 && month <= 12))
                {
                    dateCheck.Message = dateCheck.errors[ErrorName.MONTH_INVALID]._message;
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (!(day >= 1 && day <= 31))
                {
                    dateCheck.Message = dateCheck.errors[ErrorName.DAY_INVALID]._message;
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (!(year >= 1900 && year <= DateTime.Now.Year))
                {
                    dateCheck.Message = dateCheck.errors[ErrorName.YEAR_IS_INVALID]._message;
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (IsLeapYear(year) && month == 2)
                    if (day > 29)
                    {
                        dateCheck.Message = dateCheck.errors[ErrorName.YEAR_IS_LEAPYEAR]._message; ;
                        dateCheck.Result = false;
                        return dateCheck;
                    }

                if (!IsLeapYear(year) && month == 2)
                    if (day > 28)
                    {
                        dateCheck.Message = dateCheck.errors[ErrorName.YEAR_IS_NOT_LEAPYEAR]._message;
                        dateCheck.Result = false;
                        return dateCheck;
                    }

                if (IsThirtyDay(month) && day > 30)
                {
                    dateCheck.Message = dateCheck.errors[ErrorName.TOO_MUCH_DAYS]._message;
                    dateCheck.Result = false;
                    return dateCheck;
                }
            }
            else
            {
                dateCheck.Message = dateCheck.errors[ErrorName.DATE_NOT_FOUND]._message;
                dateCheck.Result = false;
                return dateCheck;
            }

            return dateCheck;
        }

        /// <summary>
        ///     Проверяет все поля номера телефона
        /// </summary>
        /// <returns>
        ///     Returns ValidationModel result and message
        /// </returns>
        public static ValidationModel ValidatePhone(Person p)
        {
            var phoneNums = new List<string>();
            var phoneCheck = new ValidationModel
            {
                Message = "",
                Result = true
            };

            phoneNums = SortPhoneNums(phoneNums, p);

            foreach (var phone in phoneNums)
                if (CleanNumbers(p.CellPhone).Length > 0 || CleanNumbers(p.HomePhone).Length > 0 ||
                    CleanNumbers(p.OfficePhone).Length > 0)
                    if (!CheckNumLen(p.CellPhone, 10) || !CheckNumLen(p.HomePhone, 10) ||
                        !CheckNumLen(p.OfficePhone, 10))
                    {
                        phoneCheck.Message = phoneCheck.errors[ErrorName.PHONE_IS_INVALID]._message;
                        phoneCheck.Result = false;
                        return phoneCheck;
                    }

            return phoneCheck;
        }
    }
}