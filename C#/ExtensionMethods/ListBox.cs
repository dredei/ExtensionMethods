#region Using

using System.Windows.Forms;

#endregion

namespace ExtensionMethods
{
    public static class ListBoxExtension
    {
        /// <summary>
        /// Скроллит в конец
        /// </summary>
        /// <param name="lb"></param>
        public static void AutoScroll( this ListBox lb )
        {
            lb.SelectedIndex = lb.Items.Count - 1;
            lb.SelectedIndex = -1;
        }
    }
}