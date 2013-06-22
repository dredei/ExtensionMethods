using System;

namespace ExtensionMethods
{
    public static class AddMethods
    {
        public static string hSize( long sizeB )
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while ( sizeB >= 1024 && order + 1 < sizes.Length )
            {
                order++;
                sizeB = sizeB / 1024;
            }
            string result = String.Format( "{0:0.##} {1}", sizeB, sizes[ order ] );
            return result;
        }
    }
}
