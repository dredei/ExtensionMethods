using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText( this RichTextBox box, string text, Color color )
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText( text );
            box.SelectionColor = box.ForeColor;
        }

        public static void AppendText( this RichTextBox box, string text, bool underLine, bool bold )
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            if ( underLine && bold )
            {
                box.SelectionFont = new Font( box.SelectionFont, FontStyle.Underline | FontStyle.Bold );
            }
            else if ( bold )
            {
                box.SelectionFont = new Font( box.SelectionFont, FontStyle.Bold );
            }
            else if ( underLine )
            {
                box.SelectionFont = new Font( box.SelectionFont, FontStyle.Underline );
            }
            box.AppendText( text );
            box.SelectionColor = box.ForeColor;
        }

        public static void AppendText( this RichTextBox box, string text, bool underLine, bool bold, Color color )
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            if ( underLine && bold )
            {
                box.SelectionFont = new Font( box.SelectionFont, FontStyle.Underline | FontStyle.Bold );
            }
            else if ( bold )
            {
                box.SelectionFont = new Font( box.SelectionFont, FontStyle.Bold );
            }
            else if ( underLine )
            {
                box.SelectionFont = new Font( box.SelectionFont, FontStyle.Underline );
            }
            box.SelectionColor = color;
            box.AppendText( text );
            box.SelectionColor = box.ForeColor;
        }

        public static void AutoSize( this RichTextBox box, Form frm )
        {
            #region AutoSize RichTextBox (Height)
            Size sz = new Size( box.ClientSize.Width, int.MaxValue );
            TextFormatFlags flags = TextFormatFlags.WordBreak;
            int padding = 3;
            int borders = box.Height - box.ClientSize.Height;
            sz = TextRenderer.MeasureText( box.Text, box.Font, sz, flags );
            int h = sz.Height + borders + padding;
            if ( box.Top + h > frm.ClientSize.Height - 10 )
            {
                h = frm.ClientSize.Height - 10 - box.Top;
            }
            box.Height = h + 10;
            #endregion
            #region AutoSize RichTextBox (Width)
            System.Drawing.SizeF mySize = new System.Drawing.SizeF();
            System.Drawing.Font myFont = box.Font;
            using ( Graphics g = frm.CreateGraphics() )
            {
                // Get the size given the string and the font
                mySize = g.MeasureString( box.Text, myFont );
            }
            box.Width = (int)Math.Round( mySize.Width, 0 ) + 10;
            #endregion
            /*Size size = box.GetPreferredSize( box.Size );
            box.Height = size.Height;
            box.Width = size.Width;*/
            /*box.Width = TextRenderer.MeasureText( box.Text, box.Font ).Width + 15;
            box.Height = TextRenderer.MeasureText( box.Text, box.Font ).Height + 15;*/
        }

        public static void AppendLine( this RichTextBox source, string value )
        {
            if ( source.Text.Length == 0 )
                source.Text = value;
            else
                source.AppendText( "\r\n" + value );
        }

        /*public static void AppendLine( this RichTextBox source, string value, Color color )
        {
            if ( source.Text.Length == 0 )
                //source.Text = value;
                source.AppendText( value, color );
            else
                source.AppendText( "\r\n" + value, color );
        }

        public static void AppendLine( this RichTextBox source, string value, bool underLine, bool bold )
        {
            if ( source.Text.Length == 0 )
                //source.Text = value;
                source.AppendText( value, underLine, bold );
            else
                source.AppendText( "\r\n" + value, underLine, bold );
        }*/
    }
}
