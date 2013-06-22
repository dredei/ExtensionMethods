using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public static class ExMethods
    {
        /// <summary>
        /// Форматирует строку
        /// </summary>
        /// <param name="format">Строка или переменная</param>
        /// <param name="args">Аргументы</param>
        /// <returns></returns>
        public static string f( this string format, params object[] args )
        {
            return String.Format( format, args );
        }

        /// <summary>
        /// Реализует сохранение данных коллекции List
        /// </summary>
        /// <param name="list">Коллекция List</param>
        /// <param name="fileName">Путь к файлу</param>
        public static void SaveToFile( this List<string> list, string fileName )
        {
            if ( !Directory.Exists( Path.GetDirectoryName( fileName ) ) )
            {
                Directory.CreateDirectory( Path.GetDirectoryName( fileName ) );
            }
            File.WriteAllLines( fileName, list.ToArray() );
        }

        /// <summary>
        /// Возвращает читабельный размер
        /// </summary>
        /// <param name="i">Размер файла в байтах</param>
        /// <returns>Форматированная строка в читабельном виде</returns>
        public static string getSizeReadable( long i )
        {
            string sign = ( i < 0 ? "-" : "" );
            double readable = ( i < 0 ? -i : i );
            string suffix;
            if ( i >= 0x1000000000000000 ) // Exabyte
            {
                suffix = "EB";
                readable = (double)( i >> 50 );
            }
            else if ( i >= 0x4000000000000 ) // Petabyte
            {
                suffix = "PB";
                readable = (double)( i >> 40 );
            }
            else if ( i >= 0x10000000000 ) // Terabyte
            {
                suffix = "TB";
                readable = (double)( i >> 30 );
            }
            else if ( i >= 0x40000000 ) // Gigabyte
            {
                suffix = "GB";
                readable = (double)( i >> 20 );
            }
            else if ( i >= 0x100000 ) // Megabyte
            {
                suffix = "MB";
                readable = (double)( i >> 10 );
            }
            else if ( i >= 0x400 ) // Kilobyte
            {
                suffix = "KB";
                readable = (double)i;
            }
            else
            {
                return i.ToString( sign + "0 B" ); // Byte
            }
            readable = readable / 1024;

            return sign + readable.ToString( "0.## " ) + suffix;
        }
    }
}
