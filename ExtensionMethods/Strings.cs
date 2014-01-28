using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class Strings
    {
        /// <summary>
        /// Форматирует строку
        /// </summary>
        /// <param name="format">Строка или переменная</param>
        /// <param name="args">Аргументы</param>
        /// <returns>Возвращает отформатированною строку</returns>
        public static string F( this string format, params object[] args )
        {
            return string.Format( format, args );
        }

        /// <summary>
        /// Проверяет пустая ли строка
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Возвращает значение, указывающее пустая ли строка</returns>
        public static bool IsNullOrEmpty( this string str )
        {
            return string.IsNullOrEmpty( str );
        }

        /// <summary>
        /// Заменяет перевод строки в ресурсах
        /// </summary>
        /// <param name="str">Любая строка</param>
        /// <returns>Строка с переносами строк</returns>
        public static string FixNewLines( this string str )
        {
            return str.Replace( @"\n", Environment.NewLine );
        }

        /// <summary>
        /// Перегруженый метод для string.Contains, позволяющий игнорировать регистр
        /// </summary>
        public static bool Contains( this string source, string toCheck, StringComparison comp )
        {
            return source.IndexOf( toCheck, comp ) >= 0;
        }
    }
}
