using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public static class ListBoxExtension
    {
        public static void AutoScroll( this ListBox lb )
        {
            lb.SelectedIndex = lb.Items.Count - 1;
            lb.SelectedIndex = -1;
        }
    }
}
