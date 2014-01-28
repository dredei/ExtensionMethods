#region Using

using System.Windows.Forms;

#endregion

namespace ExtensionMethods
{
    public static class TextBoxExtension
    {
        /// <summary>
        /// Добавляет новую строку
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        public static void AppendLine( this TextBox source, string value )
        {
            if ( source.Text.Length == 0 )
            {
                source.Text = value;
            }
            else
            {
                source.AppendText( "\r\n" + value );
            }
        }

        /// <summary>
        /// Подгоняет размеры контрола под размеры текста
        /// </summary>
        /// <param name="box"></param>
        public static void AutoSize( this TextBox box )
        {
            box.Width = TextRenderer.MeasureText( box.Text, box.Font ).Width + 15;
            box.Height = TextRenderer.MeasureText( box.Text, box.Font ).Height + 15;
        }
    }
}