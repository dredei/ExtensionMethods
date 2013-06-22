using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string f( this string format, params object[] args )
        {
            return String.Format( format, args );
        }

        public static void SaveToFile( this List<string> list, string path )
        {
            if ( !Directory.Exists( Path.GetDirectoryName( path ) ) )
            {
                Directory.CreateDirectory( Path.GetDirectoryName( path ) );
            }
            File.WriteAllLines( path, list.ToArray() );
        }
    }
}
