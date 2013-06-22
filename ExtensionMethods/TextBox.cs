using System.Windows.Forms;

namespace ExtensionMethods
{
    public static class TextBoxExtension
    {
        public static void AppendLine( this TextBox source, string value )
        {
            if ( source.Text.Length == 0 )
                source.Text = value;
            else
                source.AppendText( "\r\n" + value );
        }

        public static void AutoSize( this TextBox box )
        {            
            box.Width = TextRenderer.MeasureText( box.Text, box.Font ).Width + 15;
            box.Height = TextRenderer.MeasureText( box.Text, box.Font ).Height + 15;
        }
    }
}
