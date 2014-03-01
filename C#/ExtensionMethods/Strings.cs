#region Using

using System;
using System.Text;

#endregion

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

        /// <summary>
        /// Делает первую букву строки заглавной
        /// </summary>
        /// <param name="str">Любая строка</param>
        /// <returns>Строка, у которой первая буква заглавная</returns>
        public static string ToFirstUpper( this string str )
        {
            if ( string.IsNullOrEmpty( str ) )
            {
                return "";
            }
            var sb = new StringBuilder( str );
            sb[ 0 ] = char.ToUpper( sb[ 0 ] );
            return sb.ToString();
        }

        /// <summary>
        /// Переводит строку в число или возвращает null, если это невозможно
        /// </summary>
        /// <param name="str">Число в виде строки</param>
        /// <returns>Число или null</returns>
        public static int? ToIntWithNull( this string str )
        {
            if ( string.IsNullOrEmpty( str ) )
            {
                return null;
            }
            int num;
            if ( int.TryParse( str, out num ) )
            {
                return num;
            }
            else
            {
                return null;
            }
        }
    }
}