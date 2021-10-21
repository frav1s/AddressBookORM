using System;
using System.Collections.Generic;
using System.Linq;
namespace AddressBookLibrary.Model
{
    public enum ErrorName
    {
        PHONE_IS_INVALID,
        DATE_NOT_FOUND,
        MONTH_INVALID,
        DAY_INVALID,
        YEAR_IS_INVALID,
        YEAR_IS_LEAPYEAR,
        YEAR_IS_NOT_LEAPYEAR,
        TOO_MUCH_DAYS,
        NAME_NOT_FOUND,
        NAME_IS_MALFORMED,
        LASTNAME_IS_MALFORMED
    }
    public class Error
    {
        private int _code;
        private string _message;

        public Error(int code, string message)
        {
            _code = code;
            _message = message;
        }

    }
    public class ValidationModel
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        
        public Dictionary<ErrorName, Error> errors = new Dictionary<ErrorName, Error>();
        public ValidationModel()
        {
            errors.Add(ErrorName.PHONE_IS_INVALID, new Error(1000, "Введенный номер  телефона не содержит достаточного количества цифр."));
            errors.Add(ErrorName.DATE_NOT_FOUND, new Error(2010, "Пример даты - 01 / 01 / 1986"));
            errors.Add(ErrorName.MONTH_INVALID, new Error(2020, "Месяц должен быть между 01 и 12."));
            errors.Add(ErrorName.DAY_INVALID, new Error(2021, "День должен быть между 01 и 31."));
            errors.Add(ErrorName.YEAR_IS_INVALID, new Error(2022, "Год должен быть между 1900 и" + DateTime.Now.Year));
            errors.Add(ErrorName.YEAR_IS_LEAPYEAR, new Error(2030, "Не високосный год - в феврале не более 28 дней."));
            errors.Add(ErrorName.YEAR_IS_NOT_LEAPYEAR, new Error(2031, "Високосный год - в феврале не более 29 дней."));
            errors.Add(ErrorName.TOO_MUCH_DAYS, new Error(2040, "В этом месяце нет 31 дня."));
            errors.Add(ErrorName.NAME_NOT_FOUND, new Error(3010, "Введите имя для этого контакта."));
            errors.Add(ErrorName.NAME_IS_MALFORMED, new Error(3020, "Имя обязательно."));
            errors.Add(ErrorName.LASTNAME_IS_MALFORMED, new Error(3021, "Фамилия обязательна."));
        }
    }
}