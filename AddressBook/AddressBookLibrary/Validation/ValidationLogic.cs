using AddressBookLibrary.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AddressBookLibrary.Validation
{
    public class ValidationLogic
    {
        /// <summary>
        ///     Создает запись регулярного выражения
        /// </summary>
        private static readonly Regex rxNonDigits = new Regex(@"[^\d]+");

        /// <summary>
        ///     Добавляет ненулевые номера телефонов в список строковых номеров
        /// </summary>
        /// <param name="nums">
        ///     Список хранится в виде string
        /// </param>
        /// <param name="p">
        ///     ContactModel object
        /// </param>
        /// <returns>
        ///     Returns заполненный список строк телефонных номеров, исключая любые пустые телефонные номера
        /// </returns>
        public static List<string> SortPhoneNums(List<string> nums, Person p)
        {
            if (p.CellPhone != "(   )    -") nums.Add(p.CellPhone);

            if (p.HomePhone != "(   )    -") nums.Add(p.HomePhone);

            if (p.OfficePhone != "(   )    -") nums.Add(p.OfficePhone);

            return nums;
        }

        /// <summary>
        ///     Алгоритм опеределения високосного года
        /// </summary>
        /// <param name="year">
        ///     Год от даты рождения
        /// </param>
        /// <returns>
        ///     true, если високосный, в ином случае - false
        /// </returns>
        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
                return false;
            if (year % 100 != 0)
                return true;
            if (year % 400 != 0)
                return false;
            return true;
        }

        /// <summary>
        ///     Указывает, есть ли в месяце тридцать дней
        /// </summary>
        /// <param name="month">
        ///     Month from BirthDate
        /// </param>
        /// <returns>
        ///     True - 30 дней, False - 31 день.
        /// </returns>
        public static bool IsThirtyDay(int month)
        {
            int[] thirty = { 4, 6, 9, 11 };
            if (!InArray(month, thirty)) return false;

            return true;
        }

        /// <summary>
        ///     Проверяет массив на наличие определенного числа
        /// </summary>
        /// <param name="month">
        ///     Передается как число от 1 до 12
        /// </param>
        /// <param name="array">
        ///     Массив чисел месяца
        /// </param>
        /// <returns>
        ///     True, если число в массиве, false - если число не в массиве
        /// </returns>
        public static bool InArray(int month, int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var found = array[i];
                if (found == month) return true;
            }

            return false;
        }

        /// <summary>
        ///     Checks length of string of nums
        /// </summary>
        /// <param name="input">
        ///     Initial string of nums
        /// </param>
        /// <param name="i">
        ///     Goal length of the string of nums
        /// </param>
        /// <returns>
        ///     True if num = goal length, false if not goal length
        /// </returns>
        public static bool CheckNumLen(string input, int i)
        {
            var num = CleanNumbers(input);

            if (num.Length != i) return false;

            return true;
        }

        /// <summary>
        ///     Устраняет специальные символы для возврата строки чисел
        /// </summary>
        /// <param name="str">
        ///     String со знаками
        /// </param>
        /// <returns>
        ///     Строка чисел
        /// </returns>
        public static string CleanNumbers(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            var cleanNum = rxNonDigits.Replace(str, "");

            return cleanNum;
        }
    }
}