using AddressBookLibrary.Model;
using System;
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
            var nameCheck = new ValidationModel
            {
                Message = "",
                Result = true
            };

            if (p.FirstName.Length == 0 && p.LastName.Length == 0)
            {
                nameCheck.Message = "Введите имя для этого контакта.";
                nameCheck.Result = false;
                return nameCheck;
            }

            if (p.FirstName.Length == 0)
            {
                nameCheck.Message = "Имя обязательно.";
                nameCheck.Result = false;
                return nameCheck;
            }

            if (p.LastName.Length == 0)
            {
                nameCheck.Message = "Фамилия обязательна.";
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
                dateCheck.Message = "Пример даты - 01/01/1986";
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
                    dateCheck.Message = "Месяц должен быть между 01 и 12.";
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (!(day >= 1 && day <= 31))
                {
                    dateCheck.Message = "День должен быть между 01 и 31.";
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (!(year >= 1900 && year <= DateTime.Now.Year))
                {
                    dateCheck.Message = "Год должен быть между 1900 и" + DateTime.Now.Year;
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (IsLeapYear(year) && month == 2)
                    if (day > 29)
                    {
                        dateCheck.Message = "Високосный год - в феврале не более 29 дней.";
                        dateCheck.Result = false;
                        return dateCheck;
                    }

                if (!IsLeapYear(year) && month == 2)
                    if (day > 28)
                    {
                        dateCheck.Message = "Не високосный год - в феврале не более 28 дней.";
                        dateCheck.Result = false;
                        return dateCheck;
                    }

                if (IsThirtyDay(month) && day > 30)
                {
                    dateCheck.Message = "В этом месяце нет 31 дня.";
                    dateCheck.Result = false;
                    return dateCheck;
                }
            }
            else
            {
                dateCheck.Message = "Пример даты - 01/01/1986";
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
                        phoneCheck.Message =
                            "Введенный номер  телефона не содержит достаточного количества цифр.";
                        phoneCheck.Result = false;
                        return phoneCheck;
                    }

            return phoneCheck;
        }
    }
}