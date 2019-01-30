using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sudoku
{
    public sealed partial class ContentDialog1 : ContentDialog
    {
        public int result_dialog
        {
            get;
            set;
        }
        public ContentDialog1(string napis)
        {
            this.InitializeComponent();
            dialogBlock.Text = napis;
            this.result_dialog = 0;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.result_dialog = 1;
            this.Hide();
        }
    }
}
